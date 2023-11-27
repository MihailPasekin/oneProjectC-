using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VFlowthroughdetail
{
    public string Consignee { get; set; } = null!;

    public string Flowthrough { get; set; } = null!;

    public string Flowthroughline { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtyreceived { get; set; }

    public decimal? Qtymodified { get; set; }

    public string? Adduser { get; set; }

    public DateTime Adddate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Inputuom { get; set; }

    public string? Inputsku { get; set; }

    public decimal? Inputqty { get; set; }

    public string? Inventorystatus { get; set; }

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
