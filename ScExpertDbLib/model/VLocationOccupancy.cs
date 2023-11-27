using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLocationOccupancy
{
    public string Location { get; set; } = null!;

    public bool Status { get; set; }

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string? Locusagetype { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public double? Cubic { get; set; }

    public int Loadscapacity { get; set; }

    public string? Aisle { get; set; }

    public string? Bay { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public decimal? TotalUnits { get; set; }

    public double? TotalVolume { get; set; }

    public double? TotalWeight { get; set; }

    public int? NumLoads { get; set; }

    public int? NumPendingLoads { get; set; }

    public decimal? Pendingunits { get; set; }

    public double? PendingVolume { get; set; }

    public double? PendingWeight { get; set; }

    public string LocationOccupancy { get; set; } = null!;

    public decimal CapacityVolumePct { get; set; }
}
