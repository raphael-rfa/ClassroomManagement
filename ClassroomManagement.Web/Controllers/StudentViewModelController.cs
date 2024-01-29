using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces.Repositories;
using ClassroomManagement.Domain.Interfaces.Services;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class StudentViewModelController : Controller
    {
        public readonly IStudentService _studentService;
        public readonly ISubjectService _subjectService;
        public readonly IExamService _examService;
        public readonly IUnitOfWork _unitOfWork;


        public StudentViewModelController(IUnitOfWork unitOfWork, IExamService examService, IStudentService  studentService, ISubjectService subjectService)
        {
            _unitOfWork = unitOfWork;
            _examService = examService;
            _studentService = studentService;
            _subjectService = subjectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(int Id)
        {

            StudentViewModel aluno = await _studentService.Get(Id);
            ViewData["MateriasId"] = new SelectList(await _subjectService.GetAll(), "Id", "SubjectName");
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel notas)
        {
            if (ModelState.IsValid)
            {
                Exam provas = notas.Exam;
               await _examService.Create(provas);
                await _unitOfWork.Commit();
                ViewData["MateriasId"] = new SelectList(await _subjectService.GetAll(), "Id", "SubjectName");
                return View(notas);
            }
            ViewData["MateriasId"] = new SelectList(await _subjectService.GetAll(), "Id", "SubjectName");
            return View(notas);
        }

        public async Task<IActionResult> Edit(int id)
        {
            StudentViewModel prova = await _examService.GetWithStudentAndSubject(id);
            
            if (prova == null)
                return NotFound();

            return View(prova);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentViewModel ProvasAluno)
        {
            Exam prova = ProvasAluno.Exam;
            if (id != prova.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _examService.Update(prova);
                    await _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ProvaExists(prova.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new RouteValueDictionary(
                    new { controller = "Student", action = "Index" }));
            }
            return View(prova);
        }

        private async Task<bool> ProvaExists(int id)
        {
            return await _examService.Any(id);
        }

        //HTTP Get Delete        
        public async Task<IActionResult> Delete(int id)
        {
            StudentViewModel prova = await _examService.GetWithStudentAndSubject(id);
            
            if (prova == null)
                return NotFound();

            return View(prova);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, StudentViewModel ProvasAluno)
        {
            Exam prova = ProvasAluno.Exam;
            if (id != prova.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _examService.Delete(prova);
                    await _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ProvaExists(prova.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new RouteValueDictionary(
                    new { controller = "Student", action = "Details", prova.Student.Id }));
            }
            return View(prova);
        }
    }

}
