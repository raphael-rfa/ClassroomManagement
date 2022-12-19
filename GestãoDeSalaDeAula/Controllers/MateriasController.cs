using GestãoDeSalaDeAula.Data;
using GestãoDeSalaDeAula.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeSalaDeAula.Controllers
{
    public class MateriasController : Controller
    {
        public readonly GestãoDeSalaDeAulaContext? _context;

        public MateriasController(GestãoDeSalaDeAulaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context!.Materias != null ?
                View(await _context.Materias.ToListAsync()) :
                Problem("_context e nulo .");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, MateriasName")] Materias materias)
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
            if(id == null || _context!.Materias == null)
            {
                return NotFound();
            }

            var materias = await _context.Materias
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
            if(_context!.Materias == null)
            {
                return Problem("Contexto Nulo");
            }
            var materia = await _context.Materias.FindAsync(id);
            if(materia != null)
            {
                _context.Materias.Remove(materia);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
