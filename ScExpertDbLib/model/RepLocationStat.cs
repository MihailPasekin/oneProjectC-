using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepLocationStat
{
    public string Location { get; set; } = null!;

    public string? Status { get; set; }

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string? Locusagetype { get; set; }

    public string? Locmhtype { get; set; }

    public string? Inventory { get; set; }

    public DateTime? Lastcountdate { get; set; }

    public string Accesstype { get; set; } = null!;

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Cubic { get; set; }

    public int Loadscapacity { get; set; }

    public double? Pendingweight { get; set; }

    public double? Pendingcubic { get; set; }

    public int? Pendingloads { get; set; }

    public string? Looseid { get; set; }

    public string? Aisle { get; set; }

    public string? Bay { get; set; }

    public int? Loclevel { get; set; }

    public double? Heightfromfloor { get; set; }

    public DateTime? Lastmovein { get; set; }

    public DateTime? Lastmoveout { get; set; }

    public int? Picksfromlastcount { get; set; }
}
