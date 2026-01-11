using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;

namespace Scarlat_Iuga_ProiectWEB.Pages.Produse
{
    public class DeleteModel : PageModel
    {
        private readonly AtelierContext _context;

        public DeleteModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int ID { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();
            ID = id.Value;
            return Page();
        }

        public IActionResult OnPost()
        {
            var produs = _context.Produs.Find(ID);
            if (produs != null)
            {
                _context.Produs.Remove(produs);
                _context.SaveChanges();
            }
            return RedirectToPage("Index");
        }
    }
}
