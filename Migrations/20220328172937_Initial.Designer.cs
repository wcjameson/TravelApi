﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20220328172937_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "chicago",
                            Country = "usa"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "new york",
                            Country = "usa"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "juarez",
                            Country = "mex"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "mexico city",
                            Country = "mex"
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "alberta",
                            Country = "can"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ReviewId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            DestinationId = 1,
                            Score = 4,
                            Text = "abc",
                            UserName = "steve"
                        },
                        new
                        {
                            ReviewId = 2,
                            DestinationId = 1,
                            Score = 1,
                            Text = "def",
                            UserName = "billy"
                        },
                        new
                        {
                            ReviewId = 3,
                            DestinationId = 1,
                            Score = 3,
                            Text = "hjk",
                            UserName = "steve"
                        },
                        new
                        {
                            ReviewId = 4,
                            DestinationId = 4,
                            Score = 5,
                            Text = "nop",
                            UserName = "billy"
                        },
                        new
                        {
                            ReviewId = 5,
                            DestinationId = 4,
                            Score = 2,
                            Text = "qrs",
                            UserName = "steve"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.HasOne("TravelApi.Models.Destination", "Destination")
                        .WithMany("Reviews")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
