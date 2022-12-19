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
            return _context.Materias! != null ?
                View(await _context.Materias.ToListAsync()) :
                Problem("_context e nulo .");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MateriaId, MateriasName")] Materias materias)
        {
            if(ModelState.IsValid)
            {
                _context.Add(materias);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
