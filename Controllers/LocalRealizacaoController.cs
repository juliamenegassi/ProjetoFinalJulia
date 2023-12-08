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
    public class LocalRealizacaoController : Controller
    {
        private readonly Contexto _context;

        public LocalRealizacaoController(Contexto context)
        {
            _context = context;
        }

        // GET: LocalRealizacao
        public async Task<IActionResult> Index()
        {
            var contexto = _context.LocalRealizacao.Include(l => l.Cidade);
            return View(await contexto.ToListAsync());
        }

        // GET: LocalRealizacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LocalRealizacao == null)
            {
                return NotFound();
            }

            var localRealizacao = await _context.LocalRealizacao
                .Include(l => l.Cidade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localRealizacao == null)
            {
                return NotFound();
            }

            return View(localRealizacao);
        }

        // GET: LocalRealizacao/Create
        public IActionResult Create()
        {
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "NomeCidade");
            return View();
        }

        // POST: LocalRealizacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LocalRealizacaoNome,CidadeId")] LocalRealizacao localRealizacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localRealizacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "NomeCidade", localRealizacao.CidadeId);
            return View(localRealizacao);
        }

        // GET: LocalRealizacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LocalRealizacao == null)
            {
                return NotFound();
            }

            var localRealizacao = await _context.LocalRealizacao.FindAsync(id);
            if (localRealizacao == null)
            {
                return NotFound();
            }
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "NomeCidade", localRealizacao.CidadeId);
            return View(localRealizacao);
        }

        // POST: LocalRealizacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LocalRealizacaoNome,CidadeId")] LocalRealizacao localRealizacao)
        {
            if (id != localRealizacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localRealizacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalRealizacaoExists(localRealizacao.Id))
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
            ViewData["CidadeId"] = new SelectList(_context.Cidade, "Id", "NomeCidade", localRealizacao.CidadeId);
            return View(localRealizacao);
        }

        // GET: LocalRealizacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LocalRealizacao == null)
            {
                return NotFound();
            }

            var localRealizacao = await _context.LocalRealizacao
                .Include(l => l.Cidade)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localRealizacao == null)
            {
                return NotFound();
            }

            return View(localRealizacao);
        }

        // POST: LocalRealizacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LocalRealizacao == null)
            {
                return Problem("Entity set 'Contexto.LocalRealizacao'  is null.");
            }
            var localRealizacao = await _context.LocalRealizacao.FindAsync(id);
            if (localRealizacao != null)
            {
                _context.LocalRealizacao.Remove(localRealizacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalRealizacaoExists(int id)
        {
          return (_context.LocalRealizacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
