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
    public class CursosKController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CursosKController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CursosK
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CursoK.Include(c => c.MateriaK);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CursosK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoK = await _context.CursoK
                .Include(c => c.MateriaK)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursoK == null)
            {
                return NotFound();
            }

            return View(cursoK);
        }

        // GET: CursosK/Create
        public IActionResult Create()
        {
            ViewData["MateriaKId"] = new SelectList(_context.Set<MateriaK>(), "Id", "Nombre");
            return View();
        }

        // POST: CursosK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Grupo,AñoSem,Profesor,MateriaKId")] CursoK cursoK)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cursoK);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MateriaKId"] = new SelectList(_context.Set<MateriaK>(), "Id", "Nombre", cursoK.MateriaKId);
            return View(cursoK);
        }

        // GET: CursosK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoK = await _context.CursoK.FindAsync(id);
            if (cursoK == null)
            {
                return NotFound();
            }
            ViewData["MateriaKId"] = new SelectList(_context.Set<MateriaK>(), "Id", "Nombre", cursoK.MateriaKId);
            return View(cursoK);
        }

        // POST: CursosK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Grupo,AñoSem,Profesor,MateriaKId")] CursoK cursoK)
        {
            if (id != cursoK.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cursoK);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoKExists(cursoK.Id))
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
            ViewData["MateriaKId"] = new SelectList(_context.Set<MateriaK>(), "Id", "Nombre", cursoK.MateriaKId);
            return View(cursoK);
        }

        // GET: CursosK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoK = await _context.CursoK
                .Include(c => c.MateriaK)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cursoK == null)
            {
                return NotFound();
            }

            return View(cursoK);
        }

        // POST: CursosK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cursoK = await _context.CursoK.FindAsync(id);
            _context.CursoK.Remove(cursoK);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoKExists(int id)
        {
            return _context.CursoK.Any(e => e.Id == id);
        }
    }
}
