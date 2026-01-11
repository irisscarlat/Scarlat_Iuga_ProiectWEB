using Microsoft.EntityFrameworkCore;
using Scarlat_Iuga_ProiectWEB.Models;

namespace Scarlat_Iuga_ProiectWEB.Data
{
    public class AtelierContext : DbContext
    {
        public AtelierContext(DbContextOptions<AtelierContext> options) : base(options) { }

        public DbSet<Client> Client => Set<Client>();
        public DbSet<Croitor> Croitor => Set<Croitor>();
        public DbSet<Comanda> Comanda => Set<Comanda>();
        public DbSet<Produs> Produs => Set<Produs>();
        public DbSet<Material> Material => Set<Material>();
     
    }
}
