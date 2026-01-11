using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Comenzi
{
    public class DeleteModel : PageModel
    {
        private readonly AtelierContext _context;

        public DeleteModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Comanda Comanda { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Comanda = _context.Comanda.Find(id);
            if (Comanda == null) return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            var comanda = _context.Comanda.Find(Comanda.ID);
            if (comanda != null)
            {
                _context.Comanda.Remove(comanda);
                _context.SaveChanges();
            }

            return RedirectToPage("Index");
        }
    }
}
