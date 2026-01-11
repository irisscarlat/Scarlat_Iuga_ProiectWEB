using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Materiale
{
    public class IndexModel : PageModel
    {
        private readonly AtelierContext _context;
        public IndexModel(AtelierContext context) => _context = context;

        public IList<Material> Material { get; set; } = new List<Material>();

        public async Task OnGetAsync()
        {
            Material = await _context.Material.ToListAsync();
        }
    }
}
