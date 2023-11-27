using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VInventorytran
{
    public string Invtrans { get; set; } = null!;

    public string? Invtrntype { get; set; }

    public DateTime? Trandate { get; set; }

    public string? Consignee { get; set; }

    public string? Consigneename { get; set; }

    public string? Document { get; set; }

    public int? Line { get; set; }

    public string? Sku { get; set; }

    public string? Loadid { get; set; }

    public string? Uom { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Posttranqty { get; set; }

    public double? Cube { get; set; }

    public double? Loadweight { get; set; }

    public double? Amount { get; set; }

    public string? Reasoncode { get; set; }

    public string? Status { get; set; }

    public string? Skudesc { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
