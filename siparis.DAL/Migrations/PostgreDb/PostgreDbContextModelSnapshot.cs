﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using siparis.DAL.EF.Contexts;

#nullable disable

namespace siparis.DAL.Migrations.PostgreDb
{
    [DbContext(typeof(PostgreDbContext))]
    partial class PostgreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Siparis.Entity.Concrete.Kategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("KategoriKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Elektronik",
                            CreateDate = new DateTime(2022, 5, 31, 13, 10, 48, 64, DateTimeKind.Local).AddTicks(3552),
                            KategoriKodu = "001",
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Bilgisayar",
                            CreateDate = new DateTime(2022, 5, 31, 13, 10, 48, 64, DateTimeKind.Local).AddTicks(3566),
                            KategoriKodu = "002",
                            Name = "Bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Cep Telefonu",
                            CreateDate = new DateTime(2022, 5, 31, 13, 10, 48, 64, DateTimeKind.Local).AddTicks(3569),
                            KategoriKodu = "003",
                            Name = "Cep Telefonu"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "Beyaz Esya",
                            CreateDate = new DateTime(2022, 5, 31, 13, 10, 48, 64, DateTimeKind.Local).AddTicks(3569),
                            KategoriKodu = "004",
                            Name = "Beyaz Esya"
                        });
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("MusteriKodu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Adet")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Indirim")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SiparisMasterId")
                        .HasColumnType("integer");

                    b.Property<int>("UrunId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SiparisMasterId");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisDetay");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("KategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("MusteriId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PersonelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("KategoryId");

                    b.HasIndex("MusteriId");

                    b.HasIndex("PersonelId");

                    b.ToTable("SiparisMaster");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("KategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Urunkodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KategoryId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisDetay", b =>
                {
                    b.HasOne("Siparis.Entity.Concrete.SiparisMaster", "SiparisMaster")
                        .WithMany("SiparisDetay")
                        .HasForeignKey("SiparisMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Siparis.Entity.Concrete.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiparisMaster");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisMaster", b =>
                {
                    b.HasOne("Siparis.Entity.Concrete.Kategory", null)
                        .WithMany("Siparisler")
                        .HasForeignKey("KategoryId");

                    b.HasOne("Siparis.Entity.Concrete.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Siparis.Entity.Concrete.Personel", "Personel")
                        .WithMany("Siparisler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Urun", b =>
                {
                    b.HasOne("Siparis.Entity.Concrete.Kategory", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Kategory", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Personel", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisMaster", b =>
                {
                    b.Navigation("SiparisDetay");
                });
#pragma warning restore 612, 618
        }
    }
}
