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
    public class MateriasKController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MateriasKController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MateriasK
        public async Task<IActionResult> Index()
        {
            return View(await _context.MateriaK.ToListAsync());
        }

        // GET: MateriasK/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaK = await _context.MateriaK
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materiaK == null)
            {
                return NotFound();
            }

            return View(materiaK);
        }

        // GET: MateriasK/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MateriasK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Creditos")] MateriaK materiaK)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materiaK);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materiaK);
        }

        // GET: MateriasK/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaK = await _context.MateriaK.FindAsync(id);
            if (materiaK == null)
            {
                return NotFound();
            }
            return View(materiaK);
        }

        // POST: MateriasK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Creditos")] MateriaK materiaK)
        {
            if (id != materiaK.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materiaK);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriaKExists(materiaK.Id))
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
            return View(materiaK);
        }

        // GET: MateriasK/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaK = await _context.MateriaK
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materiaK == null)
            {
                return NotFound();
            }

            return View(materiaK);
        }

        // POST: MateriasK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materiaK = await _context.MateriaK.FindAsync(id);
            _context.MateriaK.Remove(materiaK);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MateriaKExists(int id)
        {
            return _context.MateriaK.Any(e => e.Id == id);
        }
    }
}
