using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    public class PayrollController : Controller
    {
        private readonly HospitalManagementSystemDbContext _context;
        public PayrollController(HospitalManagementSystemDbContext context) { _context = context; }

        public async Task<IActionResult> Index() => View(await _context.Payrolls.ToListAsync());

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Payrolls.FirstOrDefaultAsync(m => m.PayrollId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Payroll model)
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
            var item = await _context.Payrolls.FindAsync(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Payroll model)
        {
            if (id != model.PayrollId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Payrolls.Any(e => e.PayrollId == id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Payrolls.FirstOrDefaultAsync(m => m.PayrollId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Payrolls.FindAsync(id);
            if (item != null)
            {
                _context.Payrolls.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}