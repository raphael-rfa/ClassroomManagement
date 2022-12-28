using GestãoDeSalaDeAula.Data;
using GestãoDeSalaDeAula.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeSalaDeAula.Controllers
{
    public class ProfessoresController : Controller
    {
        public readonly GestãoDeSalaDeAulaContext? _context;

        public ProfessoresController(GestãoDeSalaDeAulaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IQueryable<ProfessoresViewModel> professores =
                from p in _context.Professores
                join pm in _context.ProfessorMateria on p.Id equals pm.ProfessoresId
                select new ProfessoresViewModel
                {
                    Id = p.Id,
                    ProfessorName = p.Name,
                    Materia = pm.Materia!.MateriasName
                };
            
            return _context!.Professores != null ?
                View(await professores.AsNoTracking().ToListAsync()) :
                Problem("_context e nulo .");
        }

        public async Task<IActionResult> Details(int id)
        {
            if(_context!.Professores == null)
            {
                return NotFound();
            }

            ProfessorProvas professor = await _context.Professores
                .Include(p => p.ProfessorMateria!)
                    .ThenInclude(m => m.Materia)
                        .ThenInclude(p => p.Provas)
                            .ThenInclude(a => a.Aluno)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id); 

            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }
    }
}
