using GestãoDeSalaDeAula.Data;
using GestãoDeSalaDeAula.Models;
using GestãoDeSalaDeAula.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestãoDeSalaDeAula.Controllers
{
    public class AlunoViewModelController : Controller
    {
        private readonly GestãoDeSalaDeAulaContext? _context;

        public AlunoViewModelController(GestãoDeSalaDeAulaContext? context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(int Id)
        {

            AlunoViewModel aluno = await _context.Alunos.FindAsync(Id);            
            ViewData["MateriasId"] = new SelectList(_context.Materias, "Id", "MateriasName");
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlunoViewModel notas)
        {
            if (ModelState.IsValid)
            {
                Provas provas = notas.provas;
                provas.AlunosId = notas.aluno.Id;
                _context!.Provas.Add(provas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }            
            ViewData["MateriasId"] = new SelectList(_context.Materias, "Id", "MateriasName", notas.provas.MateriasId);
            return View(notas);
        }
    }
}
