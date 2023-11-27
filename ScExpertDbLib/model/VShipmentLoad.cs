using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShipmentLoad
{
    public string Shipment { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Units { get; set; }

    public string? Location { get; set; }
}
