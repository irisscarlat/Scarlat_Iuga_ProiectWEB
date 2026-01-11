using System.ComponentModel.DataAnnotations;

namespace Scarlat_Iuga_ProiectWEB.Models
{
    public class Produs
    {
        public int ID { get; set; }

        [Required, StringLength(80)]
        [Display(Name = "Tip produs")]
        public string Denumire { get; set; } = "";

        [Required]
        [StringLength(120)]
        public string? Dimensiuni { get; set; } 

        
        [Display(Name = "Comanda")]
        [Required]
        public int ComandaID { get; set; }
        public Comanda? Comanda { get; set; }

     
    }
}
