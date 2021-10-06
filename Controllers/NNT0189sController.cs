using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nguyennhuthin189.Models;

namespace nguyennhuthin189.Controllers
{
    public class NNT0189sController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NNT0189sController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NNT0189s
        public async Task<IActionResult> Index()
        {
            return View(await _context.NNT0189.ToListAsync());
        }

        // GET: NNT0189s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nNT0189 = await _context.NNT0189
                .FirstOrDefaultAsync(m => m.NNTId == id);
            if (nNT0189 == null)
            {
                return NotFound();
            }

            return View(nNT0189);
        }

        // GET: NNT0189s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NNT0189s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NNTId,NNTName,NNTGender")] NNT0189 nNT0189)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nNT0189);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nNT0189);
        }

        // GET: NNT0189s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nNT0189 = await _context.NNT0189.FindAsync(id);
            if (nNT0189 == null)
            {
                return NotFound();
            }
            return View(nNT0189);
        }

        // POST: NNT0189s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NNTId,NNTName,NNTGender")] NNT0189 nNT0189)
        {
            if (id != nNT0189.NNTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nNT0189);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NNT0189Exists(nNT0189.NNTId))
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
            return View(nNT0189);
        }

        // GET: NNT0189s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nNT0189 = await _context.NNT0189
                .FirstOrDefaultAsync(m => m.NNTId == id);
            if (nNT0189 == null)
            {
                return NotFound();
            }

            return View(nNT0189);
        }

        // POST: NNT0189s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nNT0189 = await _context.NNT0189.FindAsync(id);
            _context.NNT0189.Remove(nNT0189);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NNT0189Exists(int id)
        {
            return _context.NNT0189.Any(e => e.NNTId == id);
        }
    }
}
