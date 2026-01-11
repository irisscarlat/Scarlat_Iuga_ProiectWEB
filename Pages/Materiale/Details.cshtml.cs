using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Materiale
{
    public class DetailsModel : PageModel
    {
        private readonly AtelierContext _context;
        public DetailsModel(AtelierContext context) => _context = context;

        public Material Material { get; set; } = default!;

        public void OnGet(int id)
        {
            Material = _context.Material.Find(id)!;
        }
    }
}

