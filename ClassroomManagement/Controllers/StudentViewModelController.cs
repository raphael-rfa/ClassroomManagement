using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Infrastucture.Context;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class StudentViewModelController : Controller
    {
        private readonly ClassroomManagementContext? _context;

        public StudentViewModelController(ClassroomManagementContext? context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(int Id)
        {

            StudentViewModel aluno = await _context.Students.FindAsync(Id);
            ViewData["MateriasId"] = new SelectList(_context.Subjects, "Id", "MateriasName");
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel notas)
        {
            if (ModelState.IsValid)
            {
                Exam provas = notas.Exam;
                provas.StudentId = notas.Student.Id;
                _context!.Exams.Add(provas);
                await _context.SaveChangesAsync();
                ViewData["MateriasId"] = new SelectList(_context.Subjects, "Id", "MateriasName");
                return View(notas);
            }
            ViewData["MateriasId"] = new SelectList(_context.Subjects, "Id", "MateriasName");
            return View(notas);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (_context.Exams == null)
            {
                return NotFound();
            }

            StudentViewModel prova = await _context.Exams
                .Include(a => a.Student)
                .Include(m => m.Subject)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ExamId == id);
            if (prova == null)
            {
                return NotFound();
            }
            return View(prova);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentViewModel ProvasAluno)
        {
            Exam prova = ProvasAluno.Exam;
            prova.StudentId = ProvasAluno.Exam.Student.Id;
            if (id != prova.ExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prova);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProvaExists(prova.ExamId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new RouteValueDictionary(
                    new { controller = "Alunoes", action = "Index" }));
            }
            return View(prova);
        }

        private bool ProvaExists(int id)
        {
            return (_context.Exams?.Any(e => e.ExamId == id)).GetValueOrDefault();
        }

        //HTTP Get Delete        
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Exams == null)
            {
                return NotFound();
            }

            StudentViewModel prova = await _context.Exams
                .Include(a => a.Student)
                .Include(m => m.Subject)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ExamId == id);
            if (prova == null)
            {
                return NotFound();
            }
            return View(prova);
        }

        // POST: Alunoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, StudentViewModel ProvasAluno)
        {
            Exam prova = ProvasAluno.Exam;
            prova.StudentId = ProvasAluno.Exam.Student.Id;
            if (id != prova.ExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Remove(prova);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProvaExists(prova.ExamId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new RouteValueDictionary(
                    new { controller = "Alunoes", action = "Details", prova.Student.Id }));
            }
            return View(prova);
        }
    }

}
