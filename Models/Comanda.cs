using System.ComponentModel.DataAnnotations;

namespace Scarlat_Iuga_ProiectWEB.Models
{
    public class Comanda
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data comenzii")]
        public DateTime DataComanda { get; set; } = DateTime.Today;

        [Required, StringLength(30)]
        public string Status { get; set; } = "Noua";

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data livrarii")]
        public DateTime? DataLivrare { get; set; }

        [Required]
        [Display(Name = "Client")]
        public int ClientID { get; set; }
        public Client? Client { get; set; }

        [Required]
        [Display(Name = "Croitor")]
        public int CroitorID { get; set; }
        public Croitor? Croitor { get; set; }

        public ICollection<Produs>? Produse { get; set; }
    }
}
