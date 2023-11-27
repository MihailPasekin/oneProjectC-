using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shipmentdetailsview
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public string? Shipment { get; set; }
}
