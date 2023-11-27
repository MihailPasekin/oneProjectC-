using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLoadsPutaway
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Skugroup { get; set; }

    public string? Classname { get; set; }

    public string? Storageclass { get; set; }

    public string? Transporttype { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public string? Hazclass { get; set; }

    public string? Hutype { get; set; }

    public string? Transportationclass { get; set; }

    public string? Handlingunit { get; set; }

    public string? Handlingunittype { get; set; }
}
