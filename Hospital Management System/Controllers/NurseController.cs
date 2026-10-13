using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    public class NurseController : Controller
    {
        private readonly HospitalManagementSystemDbContext _context;
        public NurseController(HospitalManagementSystemDbContext context) { _context = context; }

        public async Task<IActionResult> Index() => View(await _context.Nurses.ToListAsync());

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Nurses.FirstOrDefaultAsync(m => m.NurseId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Nurse model)
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
            var item = await _context.Nurses.FindAsync(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Nurse model)
        {
            if (id != model.NurseId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Nurses.Any(e => e.NurseId == id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Nurses.FirstOrDefaultAsync(m => m.NurseId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Nurses.FindAsync(id);
            if (item != null)
            {
                _context.Nurses.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}