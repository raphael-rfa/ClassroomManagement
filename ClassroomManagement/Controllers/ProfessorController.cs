using ClassroomManagement.Infrastucture.Context;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class ProfessorController : Controller
    {
        public readonly ClassroomManagementContext? _context;

        public ProfessorController(ClassroomManagementContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IQueryable<ProfessoresViewModel> professores =
                from p in _context.Professors
                join pm in _context.ProfessorsSubjects on p.Id equals pm.ProfessorId
                select new ProfessoresViewModel
                {
                    Id = p.Id,
                    ProfessorName = p.Name,
                    Subject = pm.Subject!.SubjectName
                };
            
            return _context!.Professors != null ?
                View(await professores.AsNoTracking().ToListAsync()) :
                Problem("_context e nulo .");
        }

        public async Task<IActionResult> Details(int id)
        {
            if(_context!.Professors == null)
            {
                return NotFound();
            }

            ProfessorExam professor = await _context.Professors
                .Include(p => p.ProfessorSubject!)
                    .ThenInclude(m => m.Subject)
                        .ThenInclude(p => p.Exams)
                            .ThenInclude(a => a.Student)
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
