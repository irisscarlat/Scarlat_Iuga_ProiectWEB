using System.ComponentModel.DataAnnotations;

namespace Scarlat_Iuga_ProiectWEB.Models
{
    public class Material
    {
        public int ID { get; set; }

        [Required, StringLength(80)]
        public string Denumire { get; set; } = ""; 

        [Range(0, 100000)]
        public decimal Pret { get; set; } 



         }
}
