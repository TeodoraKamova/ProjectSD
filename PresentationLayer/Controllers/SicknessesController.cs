using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessLayer;
using DataLayer;

namespace PresentationLayer.Controllers
{
    public class SicknessesController : Controller
    {
        private readonly HospitalDBContext _context = new HospitalDBContext();

        private CRUDContext<Sickness, int> _sicknessContext;

        public SicknessesController()
        {
            _sicknessContext = new CRUDContext<Sickness, int>(_context.Sicknesses, _context);
        }

        // GET: Sicknesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sicknesses.ToListAsync());
        }

        // GET: Sicknesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sickness = await _context.Sicknesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sickness == null)
            {
                return NotFound();
            }

            return View(sickness);
        }

        // GET: Sicknesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sicknesses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Level,Symptoms")] Sickness sickness)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sickness);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sickness);
        }

        // GET: Sicknesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sickness = await _context.Sicknesses.FindAsync(id);
            if (sickness == null)
            {
                return NotFound();
            }
            return View(sickness);
        }

        // POST: Sicknesses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Level,Symptoms")] Sickness sickness)
        {
            if (id != sickness.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sickness);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SicknessExists(sickness.Id))
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
            return View(sickness);
        }

        // GET: Sicknesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sickness = await _context.Sicknesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sickness == null)
            {
                return NotFound();
            }

            return View(sickness);
        }

        // POST: Sicknesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sickness = await _context.Sicknesses.FindAsync(id);
            _context.Sicknesses.Remove(sickness);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SicknessExists(int id)
        {
            return _context.Sicknesses.Any(e => e.Id == id);
        }
    }
}
