using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            List<Student> students = await _studentRepository.GetAllWithExams();
            List<AverageScoreGroup> studentsWithScore = students
                .Select(x => new AverageScoreGroup
                {
                    Id = x.Id,
                    Name = x.Name,
                    Average = x.Exams.Average(a => a.Score)
                })
                .OrderByDescending(a => a.Average)
                .ToList();
             
            return View(studentsWithScore);
        }

        public async Task<IActionResult> Details(int id)
        {
            var aluno = await _studentRepository.GetWithExams(id);

            if (aluno == null)
                return NotFound();

            return View(aluno);
        }

        public IActionResult Create()
        {            
            return View();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Student aluno)
        {
            if (ModelState.IsValid)
            {
                await _studentRepository.Create(aluno);
                await _unitOfWork.Commit();
                return RedirectToAction("Create", new RouteValueDictionary(
                new { controller = "StudentViewModel", action = "Create", aluno.Id }));
            }
            return View(aluno);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var aluno = await _studentRepository.Get(id);
            
            if (aluno == null)
                return NotFound();

            return View(aluno);
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Student aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _studentRepository.Update(aluno);
                    await _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await _studentRepository.GetWithExams(id);
            
            if (aluno == null)
                return NotFound();
            
            return View(aluno);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _studentRepository.Get(id)
                ?? throw new Exception("Aluno não encontrado.");
             
            _studentRepository.Delete(aluno);
            
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AlunoExists(int id)
        {
          return await _studentRepository.Any(id);
        }
    }
}
