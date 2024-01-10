using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LigaCup.Pages
{
    public class IgralciModel : PageModel
    {
        private readonly LigaCupDB _context;
        public IgralciModel(LigaCupDB context) {
            _context = context;
        }

        public List<Igralec> Igralci { get; set; } = new List<Igralec>();


        [BindProperty]
        public Igralec NovIgralec { get; set; }


        public void OnGet() {
            Igralci = _context.Igralec.ToList();
        }

        public IActionResult OnPost() {
            _context.Igralec.Add(NovIgralec);

            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
