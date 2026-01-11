using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Comenzi
{
    public class CreateModel : PageModel
    {
        private readonly AtelierContext _context;

        public CreateModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Comanda Comanda { get; set; } = new();

        public SelectList ClientList { get; set; } = default!;
        public SelectList CroitorList { get; set; } = default!;

        public void OnGet()
        {
            ClientList = new SelectList(_context.Client, "ID", "Nume");
            CroitorList = new SelectList(_context.Croitor, "ID", "Nume");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ClientList = new SelectList(_context.Client, "ID", "Nume");
                CroitorList = new SelectList(_context.Croitor, "ID", "Nume");
                return Page();
            }

            _context.Comanda.Add(Comanda);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}