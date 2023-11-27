using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPutAway
{
    public string Location { get; set; } = null!;

    public bool Status { get; set; }

    public bool Looseid { get; set; }

    public string? Locstoragetype { get; set; }

    public bool Inventory { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Cubic { get; set; }

    public double? Weight { get; set; }

    public int Loadscapacity { get; set; }

    public int Score { get; set; }

    public string? Locaccessibility { get; set; }

    public int Numloads { get; set; }

    public int PendingLoads { get; set; }

    public double TotalVolume { get; set; }

    public double TotalWeight { get; set; }

    public double Pendingvolume { get; set; }

    public double Pendingweight { get; set; }

    public string? Putregion { get; set; }

    public string Hustoragetemplate { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Warehousearea { get; set; }

    public int? Loclevel { get; set; }

    public long? Picklocdist { get; set; }

    public string? Aisle { get; set; }

    public string? Bay { get; set; }
}
