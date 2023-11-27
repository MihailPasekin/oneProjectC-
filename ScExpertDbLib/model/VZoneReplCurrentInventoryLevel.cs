using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VZoneReplCurrentInventoryLevel
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Putregion { get; set; }

    public decimal? Units { get; set; }
}
