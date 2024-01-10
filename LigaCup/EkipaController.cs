using Microsoft.AspNetCore.Mvc;
using static LigaCup.Program;

namespace LigaCup {
    public class EkipaController : Controller {

        private readonly LigaCupDB _context;

        public EkipaController(LigaCupDB context) {
            _context = context;
        }

        public IActionResult Index() {
            var ekipe = _context.Ekipa.ToList();
            return View(ekipe);
        }
    }
}
