using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDatabaseFirst.Models;

public partial class OkulContext : DbContext
{
    public OkulContext()
    {
    }

    public OkulContext(DbContextOptions<OkulContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ogrenci> Ogrencis { get; set; }

    public virtual DbSet<Sinif> Sinifs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=FatihPC\\SQLEXPRESS;Database=Okul;User Id=sa;Password=Password1;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ogrenci>(entity =>
        {
            entity.ToTable("Ogrenci");

            entity.Property(e => e.Firstname).HasMaxLength(100);
            entity.Property(e => e.Lastname).HasMaxLength(100);

            entity.HasOne(d => d.Sinif).WithMany(p => p.Ogrencis)
                .HasForeignKey(d => d.SinifId)
                .HasConstraintName("FK_Ogrenci_Sinif");
        });

        modelBuilder.Entity<Sinif>(entity =>
        {
            entity.ToTable("Sinif");

            entity.Property(e => e.SinifAd).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
