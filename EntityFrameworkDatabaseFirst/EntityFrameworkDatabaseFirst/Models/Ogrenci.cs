using System;
using System.Collections.Generic;

namespace EntityFrameworkDatabaseFirst.Models;

public partial class Ogrenci
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public int? Age { get; set; }

    public int? SinifId { get; set; }

    public virtual Sinif? Sinif { get; set; }
}
