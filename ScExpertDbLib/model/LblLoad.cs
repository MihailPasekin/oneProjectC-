using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LblLoad
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Loaduom { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Units { get; set; }

    public DateTime? Receivedate { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }
}
