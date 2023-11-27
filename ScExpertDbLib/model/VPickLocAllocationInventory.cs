using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPickLocAllocationInventory
{
    public string LoadId { get; set; } = null!;

    public decimal? AvailableUnits { get; set; }

    public string PickList { get; set; } = null!;

    public int PickListLine { get; set; }

    public string? Consignee { get; set; }

    public string? OrderId { get; set; }

    public int? OrderLine { get; set; }

    public string? Sku { get; set; }
}
