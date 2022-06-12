﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication7.Models;

namespace WebApplication7.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20220612151908_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication7.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "alan88@wp.pl",
                            FirstName = "Alan",
                            LastName = "Luerc"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "b.drozd88@wp.pl",
                            FirstName = "Beata",
                            LastName = "Drozd"
                        });
                });

            modelBuilder.Entity("WebApplication7.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicamentes");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Na gardło",
                            Name = "Cholinex",
                            Type = "PseudoLek"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Na ból",
                            Name = "Apap",
                            Type = "Lek bez recepty"
                        });
                });

            modelBuilder.Entity("WebApplication7.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirsttName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            Birthdate = new DateTime(1990, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirsttName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 2,
                            Birthdate = new DateTime(1970, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirsttName = "Ola",
                            LastName = "Kot"
                        });
                });

            modelBuilder.Entity("WebApplication7.Models.Perscription", b =>
                {
                    b.Property<int>("IdPerscription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPerscription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Perscriptions");

                    b.HasData(
                        new
                        {
                            IdPerscription = 1,
                            Date = new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPerscription = 2,
                            Date = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 2,
                            IdPatient = 1
                        });
                });

            modelBuilder.Entity("WebApplication7.Models.PerscriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPerscription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPerscription");

                    b.HasIndex("IdPerscription");

                    b.ToTable("PerscriptionsMedicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPerscription = 2,
                            Details = "Pora dowolna",
                            Dose = 3
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPerscription = 1,
                            Details = "Rano",
                            Dose = 2
                        });
                });

            modelBuilder.Entity("WebApplication7.Models.Perscription", b =>
                {
                    b.HasOne("WebApplication7.Models.Doctor", "Doctor")
                        .WithMany("Prescriptios")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication7.Models.Patient", "Patient")
                        .WithMany("Prescriptios")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("WebApplication7.Models.PerscriptionMedicament", b =>
                {
                    b.HasOne("WebApplication7.Models.Medicament", "Medicament")
                        .WithMany("PerscriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication7.Models.Perscription", "Perscription")
                        .WithMany("PerscriptionMedicaments")
                        .HasForeignKey("IdPerscription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Perscription");
                });

            modelBuilder.Entity("WebApplication7.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptios");
                });

            modelBuilder.Entity("WebApplication7.Models.Medicament", b =>
                {
                    b.Navigation("PerscriptionMedicaments");
                });

            modelBuilder.Entity("WebApplication7.Models.Patient", b =>
                {
                    b.Navigation("Prescriptios");
                });

            modelBuilder.Entity("WebApplication7.Models.Perscription", b =>
                {
                    b.Navigation("PerscriptionMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
