using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Comenzi
{
    public class IndexModel : PageModel
    {
        private readonly AtelierContext _context;

        public IndexModel(AtelierContext context)
        {
            _context = context;
        }

        public IList<Comanda> Comanda { get; set; } = new List<Comanda>();

        public async Task OnGetAsync()
        {
            Comanda = await _context.Comanda
                .Include(c => c.Client)
                .Include(c => c.Croitor)
                .ToListAsync();
        }
    }
}
