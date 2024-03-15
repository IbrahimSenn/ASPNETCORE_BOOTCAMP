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
    [Migration("20240315125227_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<int?>("OgretmenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KursId");

                    b.HasIndex("OgretmenId");

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

                    b.HasIndex("KursId");

                    b.HasIndex("OgrenciId");

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

            modelBuilder.Entity("LearningEfCore.Data.Ogretmen", b =>
                {
                    b.Property<int>("OgretmenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgretmenAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgretmenSoyad")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Telefon")
                        .HasColumnType("INTEGER");

                    b.HasKey("OgretmenId");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("LearningEfCore.Data.Kurs", b =>
                {
                    b.HasOne("LearningEfCore.Data.Ogretmen", null)
                        .WithMany("Kurslar")
                        .HasForeignKey("OgretmenId");
                });

            modelBuilder.Entity("LearningEfCore.Data.KursKayit", b =>
                {
                    b.HasOne("LearningEfCore.Data.Kurs", "Kurs")
                        .WithMany("KursKayitlari")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningEfCore.Data.Ogrenci", "Ogrenci")
                        .WithMany("KursKayitlari")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("LearningEfCore.Data.Kurs", b =>
                {
                    b.Navigation("KursKayitlari");
                });

            modelBuilder.Entity("LearningEfCore.Data.Ogrenci", b =>
                {
                    b.Navigation("KursKayitlari");
                });

            modelBuilder.Entity("LearningEfCore.Data.Ogretmen", b =>
                {
                    b.Navigation("Kurslar");
                });
#pragma warning restore 612, 618
        }
    }
}
