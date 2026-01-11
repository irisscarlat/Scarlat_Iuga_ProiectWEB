using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Croitori
{
    public class EditModel : PageModel
    {
        private readonly AtelierContext _context;

        public EditModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Croitor Croitor { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Croitor = _context.Croitor.Find(id);

            if (Croitor == null) return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(Croitor).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
