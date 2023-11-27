using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShipmentShippedNotification
{
    public string Shipment { get; set; } = null!;

    public DateTime? Shippedon { get; set; }

    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtyshipped { get; set; }

    public string? Targetcompany { get; set; }

    public string? Contact1name { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string Country { get; set; } = null!;

    public decimal? Qtydiff { get; set; }
}
