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
    public class EstudiantesKController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstudiantesKController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EstudiantesK
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstudianteK.ToListAsync());
        }

        // GET: EstudiantesK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudianteK = await _context.EstudianteK
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudianteK == null)
            {
                return NotFound();
            }

            return View(estudianteK);
        }

        // GET: EstudiantesK/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstudiantesK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Email")] EstudianteK estudianteK)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudianteK);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudianteK);
        }

        // GET: EstudiantesK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudianteK = await _context.EstudianteK.FindAsync(id);
            if (estudianteK == null)
            {
                return NotFound();
            }
            return View(estudianteK);
        }

        // POST: EstudiantesK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Email")] EstudianteK estudianteK)
        {
            if (id != estudianteK.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudianteK);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudianteKExists(estudianteK.Id))
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
            return View(estudianteK);
        }

        // GET: EstudiantesK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudianteK = await _context.EstudianteK
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudianteK == null)
            {
                return NotFound();
            }

            return View(estudianteK);
        }

        // POST: EstudiantesK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudianteK = await _context.EstudianteK.FindAsync(id);
            _context.EstudianteK.Remove(estudianteK);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudianteKExists(int id)
        {
            return _context.EstudianteK.Any(e => e.Id == id);
        }
    }
}
