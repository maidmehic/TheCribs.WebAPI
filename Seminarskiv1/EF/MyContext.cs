using Microsoft.EntityFrameworkCore;
using Seminarskiv1.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarskiv1.EF
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> x) : base(x)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

        public DbSet<DetaljiStana> DetaljiStana{ get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Stan> Stan { get; set; }
        public DbSet<ViseDetalja> ViseDetalja { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<SpasenSmjestaj> SpasenSmjestaj { get; set; }
    }
}
