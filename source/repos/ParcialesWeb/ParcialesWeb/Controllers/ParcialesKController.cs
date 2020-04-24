using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModelsK;
using ParcialesWeb.Data;

namespace ParcialesWeb.Controllers
{
    public class ParcialesKController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParcialesKController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ParcialesK
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ParcialK.Include(p => p.CursoK).Include(p => p.EstudianteK);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ParcialesK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcialK = await _context.ParcialK
                .Include(p => p.CursoK)
                .Include(p => p.EstudianteK)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parcialK == null)
            {
                return NotFound();
            }

            return View(parcialK);
        }

        // GET: ParcialesK/Create
        public IActionResult Create()
        {
            ViewData["CursoKId"] = new SelectList(_context.CursoK, "Id", "Profesor");
            ViewData["EstudianteKId"] = new SelectList(_context.EstudianteK, "Id", "Email");
            return View();
        }

        // POST: ParcialesK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Número,Fecha,Nota,Porcentaje,EstudianteKId,CursoKId")] ParcialK parcialK)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parcialK);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CursoKId"] = new SelectList(_context.CursoK, "Id", "Profesor", parcialK.CursoKId);
            ViewData["EstudianteKId"] = new SelectList(_context.EstudianteK, "Id", "Email", parcialK.EstudianteKId);
            return View(parcialK);
        }

        // GET: ParcialesK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcialK = await _context.ParcialK.FindAsync(id);
            if (parcialK == null)
            {
                return NotFound();
            }
            ViewData["CursoKId"] = new SelectList(_context.CursoK, "Id", "Profesor", parcialK.CursoKId);
            ViewData["EstudianteKId"] = new SelectList(_context.EstudianteK, "Id", "Email", parcialK.EstudianteKId);
            return View(parcialK);
        }

        // POST: ParcialesK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Número,Fecha,Nota,Porcentaje,EstudianteKId,CursoKId")] ParcialK parcialK)
        {
            if (id != parcialK.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parcialK);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParcialKExists(parcialK.Id))
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
            ViewData["CursoKId"] = new SelectList(_context.CursoK, "Id", "Profesor", parcialK.CursoKId);
            ViewData["EstudianteKId"] = new SelectList(_context.EstudianteK, "Id", "Email", parcialK.EstudianteKId);
            return View(parcialK);
        }

        // GET: ParcialesK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parcialK = await _context.ParcialK
                .Include(p => p.CursoK)
                .Include(p => p.EstudianteK)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parcialK == null)
            {
                return NotFound();
            }

            return View(parcialK);
        }

        // POST: ParcialesK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parcialK = await _context.ParcialK.FindAsync(id);
            _context.ParcialK.Remove(parcialK);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParcialKExists(int id)
        {
            return _context.ParcialK.Any(e => e.Id == id);
        }
    }
}
