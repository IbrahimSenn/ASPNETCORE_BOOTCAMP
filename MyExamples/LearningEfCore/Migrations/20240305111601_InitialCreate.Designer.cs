﻿// <auto-generated />
using System;
using LearningEfCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearningEfCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240305111601_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("LearningEfCore.Data.Kurs", b =>
                {
                    b.Property<int>("KursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KursAdi")
                        .HasColumnType("TEXT");

                    b.HasKey("KursId");

                    b.ToTable("Kurslar");
                });

            modelBuilder.Entity("LearningEfCore.Data.KursKayit", b =>
                {
                    b.Property<int>("KayitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KayitId");

                    b.ToTable("Kayitlar");
                });

            modelBuilder.Entity("LearningEfCore.Data.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Telefon")
                        .HasColumnType("INTEGER");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}