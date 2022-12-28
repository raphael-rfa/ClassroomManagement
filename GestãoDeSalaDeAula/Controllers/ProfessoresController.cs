using GestãoDeSalaDeAula.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeSalaDeAula.Controllers
{
    public class ProfessoresController : Controller
    {
        public readonly GestãoDeSalaDeAulaContext? _context;

        public ProfessoresController(GestãoDeSalaDeAulaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context!.Professores != null ?
                View(await _context.Professores.ToListAsync()) :
                Problem("_context e nulo .");
        }
    }
}
