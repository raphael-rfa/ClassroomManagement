using ClassroomManagement.Domain.Entities;
using ClassroomManagement.Infrastucture.Context;
using ClassroomManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly ClassroomManagementContext _context;

        public StudentController(ClassroomManagementContext context)
        {
            _context = context;
        }

        // GET: Alunoes
        public async Task<IActionResult> Index()
        {
            IQueryable<AverageScoreGroup> alunos =                
                from aluno in _context.Students
                join prova in _context.Exams on aluno.Id equals prova.StudentId into notas
                select new AverageScoreGroup
                {
                    Id = aluno.Id,
                    Name = aluno.Name,                    
                    Average = notas.Average(a => a.Score)
                };
            alunos = alunos.OrderByDescending(a => a.Average);
             
            return _context.Students != null ? 
                          View(await alunos.AsNoTracking().ToListAsync()):
                          Problem("Entity set 'GestãoDeSalaDeAulaContext.Aluno'  is null.");
        }

        // GET: Alunoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var aluno = await _context.Students!
                .Include(p => p.Exams!)
                    .ThenInclude(m => m.Subject)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: Alunoes/Create
        public IActionResult Create()
        {            
            return View();
        }

        // POST: Alunoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Student aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();                
                return RedirectToAction("Create", new RouteValueDictionary(
                new { controller = "AlunoViewModel", action = "Create", aluno.Id }));
            }
            return View(aluno);
        }

        // GET: Alunoes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }

            var aluno = await _context.Students.FindAsync(id);
            
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        // POST: Alunoes/Edit/5
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
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
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

        // GET: Alunoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if( id == null || _context.Students == null)
            { 
                return NotFound();
            }

            var aluno = await _context.Students
                .Include(p => p.Exams)
                .FirstOrDefaultAsync(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        // POST: Alunoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'GestãoDeSalaDeAulaContext.Aluno'  is null.");
            }
            var aluno = await _context.Students.FindAsync(id);
            if (aluno != null)
            {
                _context.Students.Remove(aluno);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(int id)
        {
          return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
