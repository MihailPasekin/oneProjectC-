using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLimboAdjustNotification
{
    public string? Invtrntype { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Loadid { get; set; }

    public string? Uom { get; set; }

    public decimal? Fromqty { get; set; }

    public decimal? Toqty { get; set; }

    public string? Reasoncode { get; set; }

    public DateTime? Trandate { get; set; }

    public string? Document { get; set; }

    public int? Line { get; set; }

    public double? Cube { get; set; }

    public double? Weight { get; set; }

    public double? Amount { get; set; }

    public string? Status { get; set; }
}
