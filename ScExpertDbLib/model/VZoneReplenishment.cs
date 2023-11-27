using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VZoneReplenishment
{
    public string Putregion { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public double Minlevel { get; set; }

    public double Maxlevel { get; set; }

    public string Replpolicy { get; set; } = null!;

    public string? Replpolicydesc { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public decimal? Hotminlevel { get; set; }

    public string? Hotreplpolicy { get; set; }

    public string? Hotreplpolicydesc { get; set; }

    public string? Putawaypolicy { get; set; }

    public string? Putawaypolicydesc { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Fromdate { get; set; }

    public decimal? Hotmaxreplqty { get; set; }

    public decimal? Normalmaxreplqty { get; set; }

    public decimal Currentqty { get; set; }

    public decimal Pendingqty { get; set; }

    public decimal Allocatedqty { get; set; }
}
