using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Domain.Interfaces;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class StudentViewModelController : Controller
    {
        public readonly IStudentRepository _studentRepository;
        public readonly ISubjectRepository _subjectRepository;
        public readonly IExamRepository _examRepository;
        public readonly IUnitOfWork _unitOfWork;


        public StudentViewModelController(IUnitOfWork unitOfWork, IExamRepository examRepository,IStudentRepository studentRepository,ISubjectRepository subjectRepository)
        {
            _unitOfWork = unitOfWork;
            _examRepository = examRepository;
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(int Id)
        {

            StudentViewModel aluno = await _studentRepository.Get(Id);
            ViewData["MateriasId"] = new SelectList(await _subjectRepository.GetAll(), "Id", "SubjectName");
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel notas)
        {
            if (ModelState.IsValid)
            {
                Exam provas = notas.Exam;
               await _examRepository.Create(provas);
                await _unitOfWork.Commit();
                ViewData["MateriasId"] = new SelectList(await _subjectRepository.GetAll(), "Id", "SubjectName");
                return View(notas);
            }
            ViewData["MateriasId"] = new SelectList(await _subjectRepository.GetAll(), "Id", "SubjectName");
            return View(notas);
        }

        public async Task<IActionResult> Edit(int id)
        {
            StudentViewModel prova = await _examRepository.GetWithStudentAndSubject(id);
            
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
                    _examRepository.Update(prova);
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
            return await _examRepository.Any(id);
        }

        //HTTP Get Delete        
        public async Task<IActionResult> Delete(int id)
        {
            StudentViewModel prova = await _examRepository.GetWithStudentAndSubject(id);
            
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
                    _examRepository.Delete(prova);
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
