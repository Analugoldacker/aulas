using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Data;
using EntityFramework.Models;

namespace EntityFramework.Controllers
{
    public class CompromissosController : Controller
    {
        private readonly EntityFrameworkContext _context;

        public CompromissosController(EntityFrameworkContext context)
        {
            _context = context;
        }

        // GET: Compromissos
        public async Task<IActionResult> Index()
        {
            var compromissos = await _context.Compromisso.ToListAsync();
            foreach (var comprom in compromissos)
            {
                comprom.Contato = await _context.Contato.FirstOrDefaultAsync(c => c.Id == comprom.ContatoId);
                comprom.Local = await _context.Local.FirstOrDefaultAsync(l => l.Id == comprom.LocalId);
            }
            return View(compromissos);
        }

        // GET: Compromissos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Compromisso == null)
            {
                return NotFound();
            }

            var compromisso = await _context.Compromisso.FirstOrDefaultAsync(m => m.Id == id);
            await _context.Contato.FirstOrDefaultAsync(c => c.Id == compromisso.ContatoId);
            await _context.Local.FirstOrDefaultAsync(l => l.Id == compromisso.LocalId);

            return View(compromisso);
        }

        // GET: Compromissos/Create
        public IActionResult Create()
        {
            var contatos = _context.Contato;
            var locais = _context.Local;
            ViewBag.Contatos = new SelectList(_context.Contato, "Id", "Nome");
            ViewBag.Locais = new SelectList(_context.Local, "Id", "Nome");
            return View();
        }

        // POST: Compromissos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Compromisso compromisso)
        {
            // if (ModelState.IsValid)
            // {
            /*  compromisso.ContatoId = 1;
                compromisso.LocalId = 1;*/
            compromisso.Local = await _context.Local.FindAsync(compromisso.LocalId);
            compromisso.Contato = await _context.Contato.FindAsync(compromisso.ContatoId);
            _context.Add(compromisso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            // }
            return View(compromisso);
        }

        // GET: Compromissos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Compromisso == null)
            {
                return NotFound();
            }

            var compromisso = await _context.Compromisso.FindAsync(id);
            if (compromisso == null)
            {
                return NotFound();
            }
            var contatos = _context.Contato;
            var locais = _context.Local;
            ViewBag.Contatos = new SelectList(_context.Contato, "Id", "Nome");
            ViewBag.Locais = new SelectList(_context.Local, "Id", "Nome");
            return View(compromisso);
        }

        // POST: Compromissos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,Data,LocalId,ContatoId")] Compromisso compromisso)
        {
            if (id != compromisso.Id)
            {
                return NotFound();
            }
            await _context.Local.FindAsync(compromisso.LocalId);
            await _context.Contato.FindAsync(compromisso.ContatoId);
            try
            {
                _context.Update(compromisso);
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompromissoExists(compromisso.Id))
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

        // GET: Compromissos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Compromisso == null)
            {
                return NotFound();
            }

            var compromisso = await _context.Compromisso
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compromisso == null)
            {
                return NotFound();
            }

            return View(compromisso);
        }

        // POST: Compromissos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Compromisso == null)
            {
                return Problem("Entity set 'EntityFrameworkContext.Compromisso'  is null.");
            }
            var compromisso = await _context.Compromisso.FindAsync(id);
            if (compromisso != null)
            {
                _context.Compromisso.Remove(compromisso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompromissoExists(int id)
        {
            return (_context.Compromisso?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
