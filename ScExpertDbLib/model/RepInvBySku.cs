using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepInvBySku
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal Units { get; set; }

    public decimal Unitsallocated { get; set; }

    public string? Warehousearea { get; set; }

    public string? Description { get; set; }

    public string? Skudesc { get; set; }

    public string? Manufacturersku { get; set; }
}
