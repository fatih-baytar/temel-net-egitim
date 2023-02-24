using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkCodeFirst.Models
{
    public class HastaneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FATIHPC\\SQLEXPRESS;Database=Hastane;User Id=sa;Password=Password1;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Doktor> Doktorlar { get; set; }
    }
}
