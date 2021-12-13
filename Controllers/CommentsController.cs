using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProject.Data;
using TermProject.Models;

namespace TermProject.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ShortStoryContext _context;

        public CommentsController(ShortStoryContext context)
        {
            _context = context;
        }

        // GET: Comments
        [HttpGet, Route("[controller]/[action]/{shortStoryID}")]
        public async Task<IActionResult> Index(string shortStoryID)
        {
            var story = await _context.ShortStories.FirstOrDefaultAsync(story => story.ID == shortStoryID);
            var comments = await _context.Comments.Include(comment => comment.Reactions).ToListAsync();
            comments = comments.OrderByDescending(comment => comment.Score).ToList();
            if (story==null)
            {
                var viewModel = new ShortStoryCommentViewModel
                {
                    Comments = comments
                };
                return View(viewModel);
            }
            else
            {
                var viewModel = new ShortStoryCommentViewModel
                {
                    ShortStoryID = shortStoryID,
                    Comments = comments.Where(comment => comment.ShortStoryID == shortStoryID).ToList(),
                    Reactions = await _context.ShortStoryReactions.Where(reaction => reaction.ShortStoryID == shortStoryID).ToListAsync(),
                    StoryContent = story.Content,
                    StoryTitle = story.Title,
                    StoryAuthor = story.Author,
                };
                return View(viewModel);
            }
        }
        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var comments = await _context.Comments.Include(comment => comment.Reactions).ToListAsync();
            comments = comments.OrderByDescending(comment => comment.Score).ToList();
            var viewModel = new ShortStoryCommentViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .FirstOrDefaultAsync(m => m.ID == id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        // GET: Comments/Create
        [Authorize]
        [HttpGet, Route("[controller]/[action]/{shortStoryID?}")]
        public async Task<IActionResult> Create(string shortStoryID)
        {
            var shortStory = await _context.ShortStories.FirstOrDefaultAsync(story => story.ID == shortStoryID);
            ViewBag.ShortStoryTitle = shortStory.Title;
            ViewBag.Author = User.Identity.Name;
            ViewBag.ShortStoryID = shortStoryID;
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("[controller]/[action]/{shortStoryID}")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Author, ShortStoryID, Content")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(comment);
        }


        [Authorize]
        public async Task<IActionResult> React(string id, Reaction reaction)
        {
            var story = await _context.Comments.FirstOrDefaultAsync(story => story.ID == id);
            if (story == null)
            {
                return NotFound();
            }

            var username = User.Identity.Name;
            var pastReactions = _context.CommentReactions.Where(reaction => reaction.CommentID == id && reaction.Author == username);
            _context.CommentReactions.RemoveRange(pastReactions);

            var commentReaction = new CommentReaction
            {
                CommentID = id,
                Author = username,
                Reaction = reaction
            };
            story.Reactions.Add(commentReaction);
            _context.Update(story);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [Authorize]
        public async Task<IActionResult> Like(string id)
        {
            return await React(id, Reaction.Like);
        }
        [Authorize]
        public async Task<IActionResult> Dislike(string id)
        {
            return await React(id, Reaction.Dislike);
        }

        // GET: Comments/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Content,ShortStoryID")] Comment comment)
        {
            if (id != comment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(comment);
        }

        // GET: Comments/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .FirstOrDefaultAsync(m => m.ID == id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var comment = await _context.Comments.FindAsync(id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(string id)
        {
            return _context.Comments.Any(e => e.ID == id);
        }
    }
}
