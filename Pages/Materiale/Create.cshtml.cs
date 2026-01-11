using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Materiale
{
    public class CreateModel : PageModel
    {
        private readonly AtelierContext _context;
        public CreateModel(AtelierContext context) => _context = context;

        [BindProperty]
        public Material Material { get; set; } = default!;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _context.Material.Add(Material);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
