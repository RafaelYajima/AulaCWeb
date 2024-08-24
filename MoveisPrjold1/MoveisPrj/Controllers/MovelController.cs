using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoveisPrj.Context;
using MoveisPrj.Models;

namespace MoveisPrj.Controllers
{
    public class MovelController : Controller
    {
        private readonly AppDbContext _context;

        public MovelController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Movel
        public async Task<IActionResult> Index()
        {
              return View(await _context.Moveis.ToListAsync());
        }

        // GET: Movel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Moveis == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis
                .FirstOrDefaultAsync(m => m.MovelId == id);
            if (movel == null)
            {
                return NotFound();
            }

            return View(movel);
        }

        // GET: Movel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovelId,Nome,Descricao,Cor,Valor,Ativo,ImagemUrl,CategoriaId")] Movel movel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movel);
        }

        // GET: Movel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Moveis == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis.FindAsync(id);
            if (movel == null)
            {
                return NotFound();
            }
            return View(movel);
        }

        // POST: Movel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovelId,Nome,Descricao,Cor,Valor,Ativo,ImagemUrl,CategoriaId")] Movel movel)
        {
            if (id != movel.MovelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovelExists(movel.MovelId))
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
            return View(movel);
        }

        // GET: Movel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Moveis == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis
                .FirstOrDefaultAsync(m => m.MovelId == id);
            if (movel == null)
            {
                return NotFound();
            }

            return View(movel);
        }

        // POST: Movel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Moveis == null)
            {
                return Problem("Entity set 'AppDbContext.Moveis'  is null.");
            }
            var movel = await _context.Moveis.FindAsync(id);
            if (movel != null)
            {
                _context.Moveis.Remove(movel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovelExists(int id)
        {
          return _context.Moveis.Any(e => e.MovelId == id);
        }
    }
}
