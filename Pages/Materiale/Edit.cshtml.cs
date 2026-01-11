using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Materiale
{
    public class EditModel : PageModel
    {
        private readonly AtelierContext _context;
        public EditModel(AtelierContext context) => _context = context;

        [BindProperty]
        public Material Material { get; set; } = default!;

        public void OnGet(int id)
        {
            Material = _context.Material.Find(id)!;
        }

        public IActionResult OnPost()
        {
            _context.Update(Material);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
