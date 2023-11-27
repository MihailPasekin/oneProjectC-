using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPickLoc
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal? Normalreplqty { get; set; }

    public decimal? Hotreplqty { get; set; }

    public decimal? Maximumqty { get; set; }

    public string Normalreplpolicy { get; set; } = null!;

    public string Hotreplpolicy { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Hotmaxreplqty { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string? Locsortorder { get; set; }

    public string? Locpicktype { get; set; }

    public string Zpickinglocation { get; set; } = null!;

    public decimal Currentqty { get; set; }

    public decimal Pendingqty { get; set; }

    public decimal Loadallocatedqty { get; set; }

    public decimal Allocatedqty { get; set; }

    public decimal? Overallocatedqty { get; set; }

    public string? Manufacturersku { get; set; }

    public int? BelowThresholdNormal { get; set; }

    public int? BelowThresholdHot { get; set; }
}
