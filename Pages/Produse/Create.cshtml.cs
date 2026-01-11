using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Produse
{
    public class CreateModel : PageModel
    {
        public SelectList ComandaList { get; set; }
        private readonly AtelierContext _context;
        public CreateModel(AtelierContext context) => _context = context;

        [BindProperty]
        public Produs Produs { get; set; } = default!;
        public SelectList Comenzi { get; set; }

        public void OnGet()
        {
            ComandaList = new SelectList(_context.Comanda, "ID", "ID");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ComandaList = new SelectList(_context.Comanda, "ID", "ID");
                return Page();
            }

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
