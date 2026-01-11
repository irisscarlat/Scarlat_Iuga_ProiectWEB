using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Scarlat_Iuga_ProiectWEB.Pages.Produse
{
    public class DetailsModel : PageModel
    {
        private readonly AtelierContext _context;

        public DetailsModel(AtelierContext context)
        {
            _context = context;
        }

        public Produs Produs { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Produs = _context.Produs
                .Include(p => p.Comanda)
                .FirstOrDefault(p => p.ID == id);

            if (Produs == null) return NotFound();

            return Page();
        }
    }
}
