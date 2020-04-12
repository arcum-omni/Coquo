using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Coquo.Data;
using Coquo.Models;

namespace Coquo.Controllers
{
    public class PantryItemsController : Controller
    {
        private readonly KitchenContext _context;

        public PantryItemsController(KitchenContext context)
        {
            _context = context;
        }

        // GET: PantryItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.PantryItem.ToListAsync());
        }

        // GET: PantryItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantryItem = await _context.PantryItem
                .FirstOrDefaultAsync(m => m.ItemID == id);
            if (pantryItem == null)
            {
                return NotFound();
            }

            return View(pantryItem);
        }

        // GET: PantryItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PantryItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemID,ItemDescription,ItemVendor,ItemQuantity,DateReceived,ExpirationDate")] PantryItem pantryItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pantryItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pantryItem);
        }

        // GET: PantryItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantryItem = await _context.PantryItem.FindAsync(id);
            if (pantryItem == null)
            {
                return NotFound();
            }
            return View(pantryItem);
        }

        // POST: PantryItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemID,ItemDescription,ItemVendor,ItemQuantity,DateReceived,ExpirationDate")] PantryItem pantryItem)
        {
            if (id != pantryItem.ItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pantryItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PantryItemExists(pantryItem.ItemID))
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
            return View(pantryItem);
        }

        // GET: PantryItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pantryItem = await _context.PantryItem
                .FirstOrDefaultAsync(m => m.ItemID == id);
            if (pantryItem == null)
            {
                return NotFound();
            }

            return View(pantryItem);
        }

        // POST: PantryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pantryItem = await _context.PantryItem.FindAsync(id);
            _context.PantryItem.Remove(pantryItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PantryItemExists(int id)
        {
            return _context.PantryItem.Any(e => e.ItemID == id);
        }
    }
}
