using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOutboundOrdersStatus
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Ordertypedesc { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public string? Statusdesc { get; set; }

    public string? Shipment { get; set; }

    public string Wave { get; set; } = null!;

    public string? Staginglane { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public DateTime Createdate { get; set; }

    public string? Companyname { get; set; }

    public string? Companygroup { get; set; }
}
