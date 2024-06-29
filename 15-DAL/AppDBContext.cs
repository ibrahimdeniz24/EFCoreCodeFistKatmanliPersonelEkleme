using _15_DAL.Mapping;
using _15_DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _15_DAL
{
    public class AppDBContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new IletisimMapping().Configure(modelBuilder.Entity<Iletisim>());
            new PersonelMapping().Configure(modelBuilder.Entity<Personel>());





            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DENIZ\SQL; Initial Catalog = HS15-PersonelEklemeDB; Integrated Security = True; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
