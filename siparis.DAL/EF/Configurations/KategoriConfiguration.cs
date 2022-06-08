using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Siparis.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparis.DAL.EF.Configurations
{
    internal class KategoriConfiguration : IEntityTypeConfiguration<Kategory>
    {
        public void Configure(EntityTypeBuilder<Kategory> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(p => p.Aciklama)
                .HasMaxLength(100)
                .IsRequired(true);

           

            builder.HasData(

            new Kategory { Id = 1, KategoriKodu = "001", Name = "Elektronik", Aciklama = "Elektronik", CreateDate = DateTime.Now },
            new Kategory { Id = 2, KategoriKodu = "002", Name = "Bilgisayar", Aciklama = "Bilgisayar", CreateDate = DateTime.Now },
            new Kategory { Id = 3, KategoriKodu = "003", Name = "Cep Telefonu", Aciklama = "Cep Telefonu", CreateDate = DateTime.Now },
            new Kategory { Id = 4, KategoriKodu = "004", Name = "Beyaz Esya", Aciklama = "Beyaz Esya", CreateDate = DateTime.Now });

        }
    }
}
