using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Data;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly AtelierContext _context;

        public IndexModel(AtelierContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; } = new List<Client>();

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
        }
    }
}
