using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShipmentUnloadingLoad
{
    public string? Shipment { get; set; }

    public string Orderid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public decimal Units { get; set; }

    public string Location { get; set; } = null!;
}
