using GestãoDeSalaDeAula.Data;
using GestãoDeSalaDeAula.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestãoDeSalaDeAula.Controllers
{
    public class ProvasController : Controller
    {
        private readonly GestãoDeSalaDeAulaContext? _context;

        public ProvasController(GestãoDeSalaDeAulaContext? context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            ViewData["AlunoId"] = new SelectList( _context!.Alunos, "Id", "Nome");
            ViewData["MateriasId"] = new SelectList(_context.Materias, "Id", "MateriasName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, AlunoId, MateriasId, Nota")] Provas provas )
        {
            if (ModelState.IsValid)
            {
                _context!.Provas.Add(provas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlunoId"] = new SelectList(_context!.Alunos, "Id", "Nome", provas.AlunoId);
            ViewData["MateriasId"] = new SelectList(_context.Materias, "Id", "MateriasName", provas.MateriasId);
            return View(provas);
        }
    }
}
