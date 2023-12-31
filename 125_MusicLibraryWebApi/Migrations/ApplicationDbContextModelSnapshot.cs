﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _125_MusicLibraryWebApi.Data;

#nullable disable

namespace _125_MusicLibraryWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_125_MusicLibraryWebApi.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Album = "Sea Change",
                            Artist = "Beck",
                            Genre = "Alternative",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 17, 21, 52, 17, 212, DateTimeKind.Local).AddTicks(6005),
                            Title = "The Golden Age"
                        },
                        new
                        {
                            Id = 5,
                            Album = "TestSea Change",
                            Artist = "TestBeck",
                            Genre = "TestAlternative",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 17, 21, 52, 17, 212, DateTimeKind.Local).AddTicks(6078),
                            Title = "TestTitle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
