using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManagement.Controllers
{
    public class SubjectController : Controller
    {
        public readonly ClassroomManagementContext? _context;
        public readonly ISubjectRepository _subjectRepository;
        public readonly IUnitOfWork _unitOfWork;

        public SubjectController(ClassroomManagementContext context, ISubjectRepository subjectRepository, IUnitOfWork unitOfWork)
        {
            _context = context;
            _subjectRepository = subjectRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _subjectRepository.GetAll());
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
                await _subjectRepository.Create(materias);
                await _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteConfirm(int id)
        {
            if(_context!.Subjects == null)
            {
                return NotFound();
            }

            var materias = await _subjectRepository.Get(id);

            if(materias == null)
                return NotFound();

            return View(materias);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var materia = await _subjectRepository.Get(id);
            if (materia != null)
            {
                _subjectRepository.Delete(materia);
            }
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}
