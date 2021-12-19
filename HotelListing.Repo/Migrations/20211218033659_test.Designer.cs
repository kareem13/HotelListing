﻿// <auto-generated />
using HotelListing.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211218033659_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HotelListing.Data.Entity.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shortname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "egypt",
                            Shortname = "egp"
                        },
                        new
                        {
                            Id = 2,
                            Name = "italy",
                            Shortname = "ity"
                        },
                        new
                        {
                            Id = 3,
                            Name = "german",
                            Shortname = "ger"
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Entity.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Countryid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Countryid");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "downtown",
                            Countryid = 1,
                            Name = "king",
                            Rating = 2.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "east",
                            Countryid = 2,
                            Name = "master",
                            Rating = 3.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "north",
                            Countryid = 3,
                            Name = "legend",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Entity.Hotel", b =>
                {
                    b.HasOne("HotelListing.Data.Entity.Country", "country")
                        .WithMany()
                        .HasForeignKey("Countryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });
#pragma warning restore 612, 618
        }
    }
}