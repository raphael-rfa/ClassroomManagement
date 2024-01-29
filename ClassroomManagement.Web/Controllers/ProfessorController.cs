using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManagement.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorSubjectService _professorSubjectService;

        public ProfessorController(IProfessorSubjectService professorService)
        {
            _professorSubjectService = professorService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _professorSubjectService.GetProfessorsAndSubjectsAsync());
        }

        public async Task<IActionResult> Details(int professorId, int subjectId)
        {
            ProfessorExam? professor = await _professorSubjectService.Get(professorId,subjectId); 

            if (professor == null)
                return NotFound();

            return View(professor);
        }
    }
}
