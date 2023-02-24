using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulOtomasyon.Data
{
    public class OkulContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FatihPC\\SQLEXPRESS;Database=Okul;User Id=sa;Password=Password1;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Sinif> Sinifs { get; set; }
        public virtual DbSet<Ogrenci> Ogrencis { get; set; }
    }
}
