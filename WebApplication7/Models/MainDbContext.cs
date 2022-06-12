using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication7.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        {
        }

        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("")
        //}

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Perscription> Perscriptions { get; set; }
        public DbSet<PerscriptionMedicament> PerscriptionsMedicaments { get; set; }
        public DbSet<Medicament> Medicamentes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Patient>(p =>
            {
                /*p.HasKey(e => e.IdPatient);
                p.Property(e => e.FirsttName).IsRequired().HasMaxLength(100);
                p.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                p.Property(e => e.Birthdate).IsRequired();*/

                p.HasData(
                    new Patient { IdPatient = 1, FirsttName = "Jan", LastName = "Kowalski", Birthdate = DateTime.Parse("1990-05-11")},
                    new Patient { IdPatient = 2, FirsttName = "Ola", LastName = "Kot", Birthdate = DateTime.Parse("1970-09-15")}
                    );
            });

            modelBuilder.Entity<Doctor>(d =>
            {
               /* d.HasKey(e => e.IdDoctor);
                d.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                d.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                d.Property(e => e.Email).IsRequired().HasMaxLength(100);*/

                d.HasData(
                    new Doctor { IdDoctor = 1, FirstName = "Alan", LastName = "Luerc", Email = "alan88@wp.pl" },
                    new Doctor { IdDoctor = 2, FirstName = "Beata", LastName = "Drozd", Email = "b.drozd88@wp.pl" }
                    );
                    
            });

            modelBuilder.Entity<Perscription>(p =>
            {
                /*p.HasKey(e => e.IdPerscription);
                p.Property(e => e.Date).IsRequired();
                p.Property(e => e.DueDate).IsRequired();

                p.HasOne(e => e.Patient).WithMany(e => e.Prescriptios).HasForeignKey(e => e.IdPatient);
                p.HasOne(e => e.Doctor).WithMany(e => e.Prescriptios).HasForeignKey(e => e.IdDoctor);*/

                p.HasData(
                    new Perscription {  IdPerscription = 1, Date  = DateTime.Parse("2022-05-01"), DueDate = DateTime.Parse("2022-09-09"), IdDoctor = 1, IdPatient = 2},
                    new Perscription {  IdPerscription = 2, Date  = DateTime.Parse("2022-08-01"), DueDate = DateTime.Parse("2022-12-09"), IdDoctor = 2, IdPatient = 1}
                    );
            });

            modelBuilder.Entity<Medicament>(p =>
            {
                p.HasData(
                    new Medicament { IdMedicament = 1, Name ="Cholinex", Description = "Na gardło", Type = "PseudoLek"},
                    new Medicament { IdMedicament = 2, Name ="Apap", Description = "Na ból", Type = "Lek bez recepty"}                    
                    );
            });

            modelBuilder.Entity<PerscriptionMedicament>(p =>
            {
                p.HasKey(r => new { r.IdMedicament, r.IdPerscription });
                p.HasData(
                    new PerscriptionMedicament { IdMedicament = 1, IdPerscription = 2, Dose = 3, Details = "Pora dowolna"},
                    new PerscriptionMedicament { IdMedicament = 2, IdPerscription = 1, Dose = 2, Details = "Rano"}
                    );
            });
        }
    }
}
