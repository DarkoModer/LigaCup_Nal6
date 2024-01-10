using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LigaCup.Pages
{
    public class TekmeModel : PageModel
    {
        private readonly LigaCupDB _context;
        public TekmeModel(LigaCupDB context) {
            _context = context;
        }

        public List<Tekma> Tekme { get; set; } = new List<Tekma>();


        [BindProperty]
        public Tekma NovTekma { get; set; }


        public void OnGet() {
            Tekme = _context.Tekma.ToList();
        }

        public IActionResult OnPost() {
            _context.Tekma.Add(NovTekma);

            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
