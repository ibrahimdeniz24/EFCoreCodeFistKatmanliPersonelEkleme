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
    public class IletisimMapping : IEntityTypeConfiguration<Iletisim>
    {
        public void Configure(EntityTypeBuilder<Iletisim> builder)
        {
            builder.HasKey(c => c.IletisimID);

            builder.HasOne(c => c.Personeliletisim)
                .WithOne(c => c.IletisimPersonel)
                .HasForeignKey<Iletisim>(c => c.PersonelID);

            builder.Property(p => p.TelefonNo).IsRequired().HasMaxLength(11);

            builder.Property(p => p.EvAdresi).HasMaxLength(255).IsRequired();

           
        }
    }
}
