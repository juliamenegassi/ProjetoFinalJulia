using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalJulia.Models;

namespace ProjetoFinalJulia.Controllers
{
    public class TipoColaboradorController : Controller
    {
        private readonly Contexto _context;

        public TipoColaboradorController(Contexto context)
        {
            _context = context;
        }

        // GET: TipoColaborador
        public async Task<IActionResult> Index()
        {
              return _context.TipoColaborador != null ? 
                          View(await _context.TipoColaborador.ToListAsync()) :
                          Problem("Entity set 'Contexto.TipoColaborador'  is null.");
        }

        // GET: TipoColaborador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoColaborador == null)
            {
                return NotFound();
            }

            var tipoColaborador = await _context.TipoColaborador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoColaborador == null)
            {
                return NotFound();
            }

            return View(tipoColaborador);
        }

        // GET: TipoColaborador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoColaborador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipoColaboradorNome")] TipoColaborador tipoColaborador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoColaborador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoColaborador);
        }

        // GET: TipoColaborador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoColaborador == null)
            {
                return NotFound();
            }

            var tipoColaborador = await _context.TipoColaborador.FindAsync(id);
            if (tipoColaborador == null)
            {
                return NotFound();
            }
            return View(tipoColaborador);
        }

        // POST: TipoColaborador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoColaboradorNome")] TipoColaborador tipoColaborador)
        {
            if (id != tipoColaborador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoColaborador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoColaboradorExists(tipoColaborador.Id))
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
            return View(tipoColaborador);
        }

        // GET: TipoColaborador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoColaborador == null)
            {
                return NotFound();
            }

            var tipoColaborador = await _context.TipoColaborador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoColaborador == null)
            {
                return NotFound();
            }

            return View(tipoColaborador);
        }

        // POST: TipoColaborador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoColaborador == null)
            {
                return Problem("Entity set 'Contexto.TipoColaborador'  is null.");
            }
            var tipoColaborador = await _context.TipoColaborador.FindAsync(id);
            if (tipoColaborador != null)
            {
                _context.TipoColaborador.Remove(tipoColaborador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoColaboradorExists(int id)
        {
          return (_context.TipoColaborador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
