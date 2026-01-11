using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private readonly AtelierContext _context;

        public DeleteModel(AtelierContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Client Client { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            Client = _context.Client.Find(id);

            if (Client == null) return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            var client = _context.Client.Find(Client.ID);
            if (client != null)
            {
                _context.Client.Remove(client);
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
