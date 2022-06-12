using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirsttName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Perscription> Prescriptios { get; set; }

    }
}
