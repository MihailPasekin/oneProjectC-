using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shipmentview
{
    public string Shipment { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Scheddate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Door { get; set; }

    public string? Carrier { get; set; }

    public string? Carriername { get; set; }

    public string Vehicleid { get; set; } = null!;

    public string Vehicletypename { get; set; } = null!;

    public DateTime? Createdate { get; set; }
}
