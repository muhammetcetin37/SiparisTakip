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
    public class MusteriConfiguration : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.Property(p => p.MusteriKodu).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Gsm).HasMaxLength(20);
        }
    }
}
