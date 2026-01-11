using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Scarlat_Iuga_ProiectWEB.Models
{
    public class Croitor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(100)]
        public string Nume { get; set; } = "";

        [Required(ErrorMessage = "Specializarea este obligatorie")]
        [StringLength(100)]
        public string? Specializare { get; set; }

        public ICollection<Comanda>? Comenzi { get; set; }
    }
}
