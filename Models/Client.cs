using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Scarlat_Iuga_ProiectWEB.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(100)]
        [Display(Name = "Nume client")]
        public string Nume { get; set; } = "";

        [EmailAddress(ErrorMessage = "Email invalid")]
        [StringLength(120)]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Telefon invalid")]
        [StringLength(30)]
        public string? Telefon { get; set; }

        public ICollection<Comanda>? Comenzi { get; set; }
    }
}
