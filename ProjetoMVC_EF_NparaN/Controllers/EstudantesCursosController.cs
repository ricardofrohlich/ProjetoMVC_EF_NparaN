using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC_EF_NparaN.DAL;
using ProjetoMVC_EF_NparaN.Models;

namespace ProjetoMVC_EF_NparaN.Controllers
{
    public class EstudantesCursosController : Controller
    {
        private readonly Contexto _context;

        public EstudantesCursosController(Contexto context)
        {
            _context = context;
        }

        // GET: EstudantesCursos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.EstudantesCursos.Include(e => e.Curso).Include(e => e.Estudante);
            return View(await contexto.ToListAsync());
        }

        // GET: EstudantesCursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudantesCursos = await _context.EstudantesCursos
                .Include(e => e.Curso)
                .Include(e => e.Estudante)
                .FirstOrDefaultAsync(m => m.EstudantesCursosId == id);
            if (estudantesCursos == null)
            {
                return NotFound();
            }

            return View(estudantesCursos);
        }

        // GET: EstudantesCursos/Create
        public IActionResult Create()
        {
            ViewData["CursoId"] = new SelectList(_context.Cursos, "CursoID", "NomeCurso");
            ViewData["EstudanteID"] = new SelectList(_context.Estudantes, "EstudanteId", "Nome");
            return View();
        }

        // POST: EstudantesCursos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstudantesCursosId,CursoId,EstudanteID")] EstudantesCursos estudantesCursos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudantesCursos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CursoId"] = new SelectList(_context.Cursos, "CursoID", "CursoID", estudantesCursos.CursoId);
            ViewData["EstudanteID"] = new SelectList(_context.Estudantes, "EstudanteId", "EstudanteId", estudantesCursos.EstudanteID);
            return View(estudantesCursos);
        }

        // GET: EstudantesCursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudantesCursos = await _context.EstudantesCursos.FindAsync(id);
            if (estudantesCursos == null)
            {
                return NotFound();
            }
            ViewData["CursoId"] = new SelectList(_context.Cursos, "CursoID", "NomeCurso", estudantesCursos.CursoId);
            ViewData["EstudanteID"] = new SelectList(_context.Estudantes, "EstudanteId", "Nome", estudantesCursos.EstudanteID);
            return View(estudantesCursos);
        }

        // POST: EstudantesCursos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstudantesCursosId,CursoId,EstudanteID")] EstudantesCursos estudantesCursos)
        {
            if (id != estudantesCursos.EstudantesCursosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudantesCursos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudantesCursosExists(estudantesCursos.EstudantesCursosId))
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
            ViewData["CursoId"] = new SelectList(_context.Cursos, "CursoID", "CursoID", estudantesCursos.CursoId);
            ViewData["EstudanteID"] = new SelectList(_context.Estudantes, "EstudanteId", "EstudanteId", estudantesCursos.EstudanteID);
            return View(estudantesCursos);
        }

        // GET: EstudantesCursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudantesCursos = await _context.EstudantesCursos
                .Include(e => e.Curso)
                .Include(e => e.Estudante)
                .FirstOrDefaultAsync(m => m.EstudantesCursosId == id);
            if (estudantesCursos == null)
            {
                return NotFound();
            }

            return View(estudantesCursos);
        }

        // POST: EstudantesCursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudantesCursos = await _context.EstudantesCursos.FindAsync(id);
            if (estudantesCursos != null)
            {
                _context.EstudantesCursos.Remove(estudantesCursos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudantesCursosExists(int id)
        {
            return _context.EstudantesCursos.Any(e => e.EstudantesCursosId == id);
        }
    }
}
