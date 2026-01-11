using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly AtelierContext _context;

        public DetailsModel(AtelierContext context)
        {
            _context = context;
        }

        public Client Client { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Client = _context.Client.Find(id);

            if (Client == null) return NotFound();

            return Page();
        }
    }
}
