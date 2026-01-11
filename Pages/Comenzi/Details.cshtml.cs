using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Comenzi
{
    public class DetailsModel : PageModel
    {
        private readonly AtelierContext _context;

        public DetailsModel(AtelierContext context)
        {
            _context = context;
        }

        public Comanda Comanda { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Comanda = _context.Comanda
                .Include(c => c.Client)
                .Include(c => c.Croitor)
                .FirstOrDefault(c => c.ID == id);

            if (Comanda == null) return NotFound();

            return Page();
        }
    }
}
