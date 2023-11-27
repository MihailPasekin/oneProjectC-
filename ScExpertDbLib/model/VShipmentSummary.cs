using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShipmentSummary
{
    public string? Shipment { get; set; }

    public int? NumOrders { get; set; }

    public int? NumLines { get; set; }

    public int? NumSkus { get; set; }

    public double? TotalWeight { get; set; }

    public double? TotalCube { get; set; }
}
