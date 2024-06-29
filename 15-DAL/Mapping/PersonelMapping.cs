using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _15_DATA;

namespace _15_DAL.Mapping
{
    public class PersonelMapping : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(h => h.PersonelID);

            builder.Property(p => p.Ad).HasMaxLength(15).IsRequired();

            builder.Property(p => p.Soyad).HasMaxLength(15).IsRequired();

            builder.Property(p => p.TCKNO).HasMaxLength(11).IsRequired();

            builder.Property(p => p.Cinsiyet); 

            builder.Property(p => p.DogumTarihi).IsRequired();

            builder.Property(p => p.Birim).IsRequired(false);
        }
    }
}