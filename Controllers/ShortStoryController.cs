using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShortStories.ToListAsync());
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

        // GET: ShortStory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShortStory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Content")] ShortStory shortStory)
        {
            if (ModelState.IsValid)
            {
                shortStory.Likes = 0;
                shortStory.Dislikes = 0;
                shortStory.ID = Guid.NewGuid().ToString();
                _context.Add(shortStory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shortStory);
        }

        // GET: ShortStory/Edit/5
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
