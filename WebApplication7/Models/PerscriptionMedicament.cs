using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    public class PerscriptionMedicament
    {
        public int IdMedicament { get; set; }
        public int IdPerscription { get; set; }

        [Required]
        public int Dose { get; set; }
        [Required, MaxLength(100)]
        public string Details { get; set; }

        [ForeignKey("IdMedicament")]
        public virtual Medicament Medicament { get; set; }
        [ForeignKey("IdPerscription")]
        public virtual Perscription Perscription { get; set; }
    }
}
