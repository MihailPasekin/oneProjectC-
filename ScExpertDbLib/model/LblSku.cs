using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LblSku
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Skushortdesc { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Vendorsku { get; set; }

    public string? Othersku { get; set; }

    public string? Skugroup { get; set; }

    public string? Classname { get; set; }

    public bool Status { get; set; }

    public bool Inventory { get; set; }

    public bool Newsku { get; set; }

    public string Initialstatus { get; set; } = null!;

    public string Velocity { get; set; } = null!;

    public double? Fifoindifference { get; set; }

    public decimal? Onsitemin { get; set; }

    public decimal? Onsitemax { get; set; }

    public DateTime? Lastcyclecount { get; set; }

    public int? Cyclecountint { get; set; }

    public int? Lowlimitcount { get; set; }

    public string? Preflocation { get; set; }

    public string? Prefputregion { get; set; }

    public double? Unitprice { get; set; }

    public string? Picture { get; set; }

    public string? Picksortorder { get; set; }

    public string? Defaultuom { get; set; }

    public decimal? Overpickpct { get; set; }

    public decimal? Overreceivepct { get; set; }

    public decimal? Dailydemand { get; set; }

    public decimal? Dailypicks { get; set; }

    public bool? Oportunityrelpflag { get; set; }

    public string? Transportationclass { get; set; }

    public string? Hazclass { get; set; }

    public string? Hutype { get; set; }

    public string? Defaultrecuom { get; set; }

    public string? Storageclass { get; set; }

    public int? Counttolerance { get; set; }

    public string? Baseitem { get; set; }

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
