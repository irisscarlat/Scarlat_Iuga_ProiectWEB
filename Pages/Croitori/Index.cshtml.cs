using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Croitori
{
    public class IndexModel : PageModel
    {
        private readonly AtelierContext _context;

        public IndexModel(AtelierContext context)
        {
            _context = context;
        }

        public IList<Croitor> Croitor { get; set; } = new List<Croitor>();

        public async Task OnGetAsync()
        {
            Croitor = await _context.Croitor.ToListAsync();
        }
    }
}
