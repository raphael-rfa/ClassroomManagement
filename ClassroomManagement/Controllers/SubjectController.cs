using ClassroomManagement.Data;
using ClassroomManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class SubjectController : Controller
    {
        public readonly ClassroomManagementContext? _context;

        public SubjectController(ClassroomManagementContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context!.Subjects != null ?
                View(await _context.Subjects.ToListAsync()) :
                Problem("_context e nulo .");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, MateriasName")] Subject materias)
        {
            if(ModelState.IsValid)
            {
                _context!.Add(materias);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if(id == null || _context!.Subjects == null)
            {
                return NotFound();
            }

            var materias = await _context.Subjects
                .FirstOrDefaultAsync(m => m.Id == id);
            if(materias == null)
            {
                return NotFound();
            }

            return View(materias);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if(_context!.Subjects == null)
            {
                return Problem("Contexto Nulo");
            }
            var materia = await _context.Subjects.FindAsync(id);
            if(materia != null)
            {
                _context.Subjects.Remove(materia);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
