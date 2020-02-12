﻿// <auto-generated />
using System;
using Greatt.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Greatt.DAL.Migrations
{
    [DbContext(typeof(GreattContext))]
    partial class GreattContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Greatt.DAL.Entities.AdherentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroLicenceFFTT")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prenom")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("AdherentEntity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AdherentEntity");
                });

            modelBuilder.Entity("Greatt.DAL.Entities.ClubEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroClubFFTT")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Greatt.DAL.Entities.JoueurEntity", b =>
                {
                    b.HasBaseType("Greatt.DAL.Entities.AdherentEntity");

                    b.Property<string>("CodeOrdre")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("JoueurEntity");
                });

            modelBuilder.Entity("Greatt.DAL.Entities.JugeEntity", b =>
                {
                    b.HasBaseType("Greatt.DAL.Entities.AdherentEntity");

                    b.Property<string>("AdresseMail")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("JugeEntity");
                });

            modelBuilder.Entity("Greatt.DAL.Entities.AdherentEntity", b =>
                {
                    b.HasOne("Greatt.DAL.Entities.ClubEntity", "Club")
                        .WithMany("Adherents")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}