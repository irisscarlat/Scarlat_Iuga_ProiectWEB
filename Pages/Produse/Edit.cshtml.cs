using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Produse
{
    public class EditModel : PageModel
    {
        private readonly AtelierContext _context;

        public EditModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produs Produs { get; set; } = default!;

        public SelectList ComandaList { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Produs = _context.Produs.Find(id);
            if (Produs == null) return NotFound();

            ComandaList = new SelectList(_context.Comanda, "ID", "ID");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ComandaList = new SelectList(_context.Comanda, "ID", "ID");
                return Page();
            }

            _context.Attach(Produs).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
