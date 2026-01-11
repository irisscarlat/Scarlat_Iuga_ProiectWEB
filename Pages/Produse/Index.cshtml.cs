using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Produse
{
    public class IndexModel : PageModel
    {
        private readonly AtelierContext _context;

        public IndexModel(AtelierContext context)
        {
            _context = context;
        }

        public IList<Produs> Produs { get; set; } = new List<Produs>();

        public async Task OnGetAsync()
        {
            Produs = await _context.Produs
                .Include(p => p.Comanda)
                .ToListAsync();
        }
    }
}
