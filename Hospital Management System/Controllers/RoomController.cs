using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    public class RoomController : Controller
    {
        private readonly HospitalManagementSystemDbContext _context;
        public RoomController(HospitalManagementSystemDbContext context) { _context = context; }

        public async Task<IActionResult> Index() => View(await _context.Rooms.ToListAsync());

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Rooms.FirstOrDefaultAsync(m => m.RoomId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Room model)
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
            var item = await _context.Rooms.FindAsync(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Room model)
        {
            if (id != model.RoomId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Rooms.Any(e => e.RoomId == id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var item = await _context.Rooms.FirstOrDefaultAsync(m => m.RoomId == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Rooms.FindAsync(id);
            if (item != null)
            {
                _context.Rooms.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}