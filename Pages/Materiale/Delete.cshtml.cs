using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;

namespace Scarlat_Iuga_ProiectWEB.Pages.Materiale
{
    public class DeleteModel : PageModel
    {
        private readonly AtelierContext _context;
        public DeleteModel(AtelierContext context) => _context = context;

        [BindProperty]
        public int ID { get; set; }

        public IActionResult OnPost()
        {
            var material = _context.Material.Find(ID);
            _context.Material.Remove(material!);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
