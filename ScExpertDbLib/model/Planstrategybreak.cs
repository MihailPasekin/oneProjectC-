using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Planstrategybreak
{
    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Pickregion { get; set; }

    public string? Picktype { get; set; }

    public string? Uom { get; set; }

    public string? Container { get; set; }

    public bool? Plancontainer { get; set; }

    public string? Packarea { get; set; }

    public string? Deliverylocation { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Cube { get; set; }

    public decimal? Minplannedcube { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public decimal? Minplannedweight { get; set; }

    public decimal? Nosplitlinecubepct { get; set; }

    public decimal? Nosplitlineweightpct { get; set; }

    public bool? Extendwalkforfill { get; set; }

    public bool? Allowmultibaseitems { get; set; }

    public int? Numberofitems { get; set; }

    public int? Numberofpicks { get; set; }
}
