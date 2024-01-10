using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LigaCup.Pages {
    public class Prijava : PageModel {
        private readonly ILogger<PrivacyModel> _logger;

        public Prijava(ILogger<PrivacyModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
        }
    }
}