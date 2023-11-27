using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class InvSkuOpenOrder
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public decimal? Units { get; set; }

    public decimal? Units4wallinv { get; set; }

    public decimal? Unitsavailable { get; set; }

    public decimal? Unitsonhold { get; set; }

    public decimal? Unitsinlimbo { get; set; }

    public decimal? Unitsallocated { get; set; }

    public decimal? Unitsinprocess { get; set; }

    public string? Skudesc { get; set; }

    public decimal? QtyInOpenReceipts { get; set; }

    public decimal? QtyInOpenOutboundOrders { get; set; }

    public decimal? QtyInOpenInboundOrders { get; set; }
}
