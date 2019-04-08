﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi;

namespace WebApi.Migrations
{
    [DbContext(typeof(AdapostContext))]
    [Migration("20190405140623_AAA2")]
    partial class AAA2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdoptionDate");

                    b.Property<int>("Age");

                    b.Property<int>("CaretakerId");

                    b.Property<int>("Health");

                    b.Property<DateTime?>("LeaveDate");

                    b.Property<string>("Name");

                    b.Property<int>("OwnerId");

                    b.Property<int>("SpeciesId");

                    b.HasKey("AnimalId");

                    b.HasIndex("CaretakerId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            AdoptionDate = new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Age = 3,
                            CaretakerId = 1,
                            Health = 1,
                            Name = "Rex",
                            OwnerId = 1,
                            SpeciesId = 1
                        });
                });

            modelBuilder.Entity("WebApi.Caretaker", b =>
                {
                    b.Property<int>("CaretakerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BossId");

                    b.Property<string>("Email");

                    b.Property<DateTime>("EmployDate");

                    b.Property<string>("Name");

                    b.HasKey("CaretakerId");

                    b.HasIndex("BossId");

                    b.ToTable("Caretakers");

                    b.HasData(
                        new
                        {
                            CaretakerId = 1,
                            EmployDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Joe"
                        },
                        new
                        {
                            CaretakerId = 2,
                            BossId = 1,
                            EmployDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jerry"
                        },
                        new
                        {
                            CaretakerId = 3,
                            BossId = 1,
                            EmployDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jon"
                        },
                        new
                        {
                            CaretakerId = 4,
                            BossId = 2,
                            EmployDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Remus"
                        },
                        new
                        {
                            CaretakerId = 5,
                            BossId = 2,
                            EmployDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marius"
                        },
                        new
                        {
                            CaretakerId = 6,
                            BossId = 2,
                            EmployDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Artem"
                        });
                });

            modelBuilder.Entity("WebApi.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            OwnerId = 1,
                            Name = "John"
                        });
                });

            modelBuilder.Entity("WebApi.Species", b =>
                {
                    b.Property<int>("SpeciesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("SpeciesId");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            SpeciesId = 1,
                            Name = "Labrador"
                        });
                });

            modelBuilder.Entity("WebApi.Animal", b =>
                {
                    b.HasOne("WebApi.Caretaker", "Caretaker")
                        .WithMany("Animals")
                        .HasForeignKey("CaretakerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Owner", "Owner")
                        .WithMany("Animals")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Species", "Species")
                        .WithMany("Animals")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApi.Caretaker", b =>
                {
                    b.HasOne("WebApi.Caretaker", "Boss")
                        .WithMany("Subalterni")
                        .HasForeignKey("BossId");
                });
#pragma warning restore 612, 618
        }
    }
}
