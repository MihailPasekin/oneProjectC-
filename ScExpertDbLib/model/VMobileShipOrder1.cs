using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileShipOrder1
{
    public string Orderid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Shipment { get; set; }

    public string? Company { get; set; }

    public string? Status { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string Spacer { get; set; } = null!;
}
