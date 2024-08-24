using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Time2Prj.Context;
using Time2Prj.Models;

namespace Time2Prj.Controllers
{
    public class TimesController : Controller
    {
        private readonly AppDbContext _context;

        public TimesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Times
        public async Task<IActionResult> Index()
        {
            return _context.Times != null ?
                        View(await _context.Times.ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Times'  is null.");
        }

        // GET: Times/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Times == null)
            {
                return NotFound();
            }

            var time = await _context.Times
                .FirstOrDefaultAsync(m => m.TimeId == id);
            if (time == null)
            {
                return NotFound();
            }

            return View(time);
        }

        // GET: Times/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Times/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeId,Nome,AnoFundacao,Liga")] Time time)
        {
            if (ModelState.IsValid)
            {
                _context.Add(time);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(time);
        }

        // GET: Times/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Times == null)
            {
                return NotFound();
            }

            var time = await _context.Times.FindAsync(id);
            if (time == null)
            {
                return NotFound();
            }
            return View(time);
        }

        // POST: Times/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimeId,Nome,AnoFundacao,Liga")] Time time)
        {
            if (id != time.TimeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(time);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeExists(time.TimeId))
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
            return View(time);
        }

        // GET: Times/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Times == null)
            {
                return NotFound();
            }

            var time = await _context.Times
                .FirstOrDefaultAsync(m => m.TimeId == id);
            if (time == null)
            {
                return NotFound();
            }

            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Times == null)
            {
                return Problem("Entity set 'AppDbContext.Times'  is null.");
            }
            var time = await _context.Times.FindAsync(id);
            if (time != null)
            {
                _context.Times.Remove(time);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeExists(int id)
        {
            return (_context.Times?.Any(e => e.TimeId == id)).GetValueOrDefault();
        }
    }
}
