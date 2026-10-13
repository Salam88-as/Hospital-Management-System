using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    public class WardController : Controller
    {
        private readonly HospitalManagementSystemDbContext _context;
        public WardController(HospitalManagementSystemDbContext context) { _context = context; }

        public async Task<IActionResult> Index() => View(await _context.Wards.ToListAsync());

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Wards.FirstOrDefaultAsync(m => m.WardId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ward model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Wards.FindAsync(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Ward model)
        {
            if (id != model.WardId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Wards.Any(e => e.WardId == id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Wards.FirstOrDefaultAsync(m => m.WardId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Wards.FindAsync(id);
            if (item != null)
            {
                _context.Wards.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}