using Microsoft.EntityFrameworkCore;
using siparis.DAL.EF.Configurations;
using Siparis.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparis.DAL.EF.Contexts
{
    public class PostgreDbContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategory> Kategoriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<SiparisMaster> SiparisMaster { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;
                                         Database=SiparisYonetimi;
                                         User Id=postgres;
                                         password=123");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Müşteri tablosundaki alanların ozelliklerini belirledigimiz yer
            modelBuilder.ApplyConfiguration(new MusteriConfiguration());

            //kategori tablosu için gerekli konfiguration dosyası eklenir
            modelBuilder.ApplyConfiguration(new KategoriConfiguration());

        }
    }
}
