using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManagement.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorSubjectRepository _professorSubjectRepository;

        public ProfessorController(IProfessorSubjectRepository professorRepository)
        {
            _professorSubjectRepository = professorRepository;
        }

        public async Task<IActionResult> Index()
        {
            var professorsSubject = await _professorSubjectRepository.GetProfessorsAndSubjectsAsync();
            
            List<ProfessoresViewModel> professoresViewModel = professorsSubject
                .Select(x => new ProfessoresViewModel
                {
                    ProfessorId = x.Professor!.Id,
                    ProfessorName = x.Professor!.Name,
                    SubjectName = x.Subject!.SubjectName,
                    SubjectId = x.Subject!.Id,
                }).ToList();
            
            return View(professoresViewModel);
        }

        public async Task<IActionResult> Details(int professorId, int subjectId)
        {
            ProfessorExam? professor = await _professorSubjectRepository.Get(professorId,subjectId); 

            if (professor == null)
                return NotFound();

            return View(professor);
        }
    }
}
