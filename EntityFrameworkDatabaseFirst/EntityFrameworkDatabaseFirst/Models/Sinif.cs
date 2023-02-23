using System;
using System.Collections.Generic;

namespace EntityFrameworkDatabaseFirst.Models;

public partial class Sinif
{
    public int Id { get; set; }

    public string? SinifAd { get; set; }

    public int Kapasite { get; set; }

    public bool? AktifMi { get; set; }

    public virtual ICollection<Ogrenci> Ogrencis { get; } = new List<Ogrenci>();
    //many to one 
}
