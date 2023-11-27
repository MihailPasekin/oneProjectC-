using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepContentList
{
    public string Container { get; set; } = null!;

    public string? Hutype { get; set; }

    public string? Oncontainer { get; set; }

    public string? Usagetype { get; set; }

    public string? Serial { get; set; }

    public string? Destinationlocation { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal Unitsavailable { get; set; }

    public string? Consigneename { get; set; }

    public string? Location { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Attserial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public string Containerid { get; set; } = null!;

    public int? Numloads { get; set; }
}
