﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veteriner.DataBase;

#nullable disable

namespace Veteriner.Migrations
{
    [DbContext(typeof(ApplicationConnectionDb))]
    [Migration("20230303202110_V7")]
    partial class V7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Veteriner.DataBase.Hayvan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cinsi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("KimlikNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("KisiId")
                        .HasColumnType("int");

                    b.Property<string>("NotBilgisi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Hayvan");
                });

            modelBuilder.Entity("Veteriner.DataBase.Kategori", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("Veteriner.DataBase.Kisi", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Kisi");
                });
#pragma warning restore 612, 618
        }
    }
}
