using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Inventorytran
{
    public string Invtrans { get; set; } = null!;

    public string? Invtrntype { get; set; }

    public DateTime? Trandate { get; set; }

    public string? Consignee { get; set; }

    public string? Document { get; set; }

    public int? Line { get; set; }

    public string? Sku { get; set; }

    public string? Loadid { get; set; }

    public string? Uom { get; set; }

    public decimal? Qty { get; set; }

    public double? Cube { get; set; }

    public double? Weight { get; set; }

    public double? Amount { get; set; }

    public string? Reasoncode { get; set; }

    public string? Status { get; set; }

    public decimal? Posttranqty { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
