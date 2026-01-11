using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Comenzi
{
    public class EditModel : PageModel
    {
        private readonly AtelierContext _context;

        public EditModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Comanda Comanda { get; set; } = default!;

        public SelectList ClientList { get; set; }
        public SelectList CroitorList { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Comanda = _context.Comanda.Find(id);
            if (Comanda == null) return NotFound();

            ClientList = new SelectList(_context.Client, "ID", "Nume");
            CroitorList = new SelectList(_context.Croitor, "ID", "Nume");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                OnGet(Comanda.ID);
                return Page();
            }

            _context.Attach(Comanda).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}

