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
    public class ShortStoryController : Controller
    {
        private readonly ShortStoryContext _context;

        public ShortStoryController(ShortStoryContext context)
        {
            _context = context;
        }

        // GET: ShortStory
        public async Task<IActionResult> Index(string? searchQuery)
        {
            List<ShortStory> stories = await _context.ShortStories.Include(story => story.Reactions).ToListAsync();
            stories = stories.OrderByDescending(story => story.Score).ToList();

            if (!String.IsNullOrEmpty(searchQuery))
            {
                stories = stories.Where(story => story.Title.Contains(searchQuery)).ToList();
            }

            var viewModel = new ShortStoryIndexViewModel
            {
                SearchQuery = searchQuery,
                Stories = stories
            };
            return View(viewModel);
        }

        // GET: ShortStory/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortStory = await _context.ShortStories
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shortStory == null)
            {
                return NotFound();
            }

            return View(shortStory);
        }

        public async Task<IActionResult> React(string id, Reaction reaction)
        {
            var story = await _context.ShortStories.FirstOrDefaultAsync(story => story.ID == id);
            if (story == null)
            {
                return NotFound();
            }

            var username = User.Identity.Name;
            var pastReactions = _context.ShortStoryReactions.Where(reaction => reaction.ShortStoryID == id && reaction.Author == username);
            _context.ShortStoryReactions.RemoveRange(pastReactions);

            var storyReaction = new ShortStoryReaction
            {
                ShortStoryID = id,
                Author = username,
                Reaction = reaction
            };
            story.Reactions.Add(storyReaction);
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

        // GET: ShortStory/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewBag.Author = User.Identity.Name;
            return View();
        }

        // POST: ShortStory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title, Author, Content")] ShortStory shortStory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shortStory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shortStory);
        }

        // GET: ShortStory/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortStory = await _context.ShortStories.FindAsync(id);
            if (shortStory == null)
            {
                return NotFound();
            }
            return View(shortStory);
        }

        // POST: ShortStory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Content")] ShortStory shortStory)
        {
            if (id != shortStory.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shortStory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShortStoryExists(shortStory.ID))
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
            return View(shortStory);
        }

        // GET: ShortStory/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shortStory = await _context.ShortStories
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shortStory == null)
            {
                return NotFound();
            }

            return View(shortStory);
        }

        // POST: ShortStory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var shortStory = await _context.ShortStories.FindAsync(id);
            _context.ShortStories.Remove(shortStory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShortStoryExists(string id)
        {
            return _context.ShortStories.Any(e => e.ID == id);
        }
    }
}
