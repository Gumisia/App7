using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models
{
    public class Perscription
    {
        [Key]
        public int IdPerscription { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }

        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        [ForeignKey("IdDoctor")]
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<PerscriptionMedicament> PerscriptionMedicaments { get; set; }

    }
}
