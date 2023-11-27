using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepInvTran
{
    public string Invtrans { get; set; } = null!;

    public string? Trandesc { get; set; }

    public string? Consignee { get; set; }

    public string? Document { get; set; }

    public int? Line { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Loadid { get; set; }

    public string? Uom { get; set; }

    public decimal? Qty { get; set; }

    public DateTime? Trandate { get; set; }
}
