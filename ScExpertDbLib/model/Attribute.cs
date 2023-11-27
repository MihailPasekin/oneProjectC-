using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Attribute
{
    public string Pkeytype { get; set; } = null!;

    public string Pkey1 { get; set; } = null!;

    public string Pkey2 { get; set; } = null!;

    public string Pkey3 { get; set; } = null!;

    public DateTime? Mfgdate { get; set; }

    public string? Serial { get; set; }

    public string? Batch { get; set; }

    public string? Size { get; set; }

    public decimal? Weight { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public DateTime? Expirydate { get; set; }
}
