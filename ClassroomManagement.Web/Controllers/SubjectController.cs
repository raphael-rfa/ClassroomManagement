using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomManagement.Controllers
{
    public class SubjectController : Controller
    {
        public readonly ClassroomManagementContext? _context;
        public readonly ISubjectService _subjectService;
        public readonly IUnitOfWork _unitOfWork;

        public SubjectController(ClassroomManagementContext context, ISubjectService subjectService, IUnitOfWork unitOfWork)
        {
            _context = context;
            _subjectService = subjectService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _subjectService.GetAll());
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
                await _subjectService.Create(materias);
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

            var materias = await _subjectService.Get(id);

            if(materias == null)
                return NotFound();

            return View(materias);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var materia = await _subjectService.Get(id);
            if (materia != null)
            {
                _subjectService.Delete(materia);
            }
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}
