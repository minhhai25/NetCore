using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lession7NETCORE.Models;

namespace Lession7NETCORE.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class OdersController : Controller
    {
        private readonly Tes1Context _context;

        public OdersController(Tes1Context context)
        {
            _context = context;
        }

        // GET: Admins/Oders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Oders.ToListAsync());
        }

        // GET: Admins/Oders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oder = await _context.Oders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oder == null)
            {
                return NotFound();
            }

            return View(oder);
        }

        // GET: Admins/Oders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Oders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,TotalPrice,Name,Phone,Address")] Oder oder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oder);
        }

        // GET: Admins/Oders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oder = await _context.Oders.FindAsync(id);
            if (oder == null)
            {
                return NotFound();
            }
            return View(oder);
        }

        // POST: Admins/Oders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,TotalPrice,Name,Phone,Address")] Oder oder)
        {
            if (id != oder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OderExists(oder.Id))
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
            return View(oder);
        }

        // GET: Admins/Oders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oder = await _context.Oders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oder == null)
            {
                return NotFound();
            }

            return View(oder);
        }

        // POST: Admins/Oders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oder = await _context.Oders.FindAsync(id);
            if (oder != null)
            {
                _context.Oders.Remove(oder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OderExists(int id)
        {
            return _context.Oders.Any(e => e.Id == id);
        }
    }
}
