using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LigaCup.Pages
{
    public class EkipeModel : PageModel
    {
        private readonly LigaCupDB _context;
        public EkipeModel(LigaCupDB context) {
            _context = context;
        }

        public List<Ekipa> Ekipe { get; set; } = new List<Ekipa>();


        [BindProperty]
        public Ekipa NovEkipe { get; set; }


        public void OnGet() {
            Ekipe = _context.Ekipa.ToList();
        }

        public IActionResult OnPost() {
            _context.Ekipa.Add(NovEkipe);

            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
