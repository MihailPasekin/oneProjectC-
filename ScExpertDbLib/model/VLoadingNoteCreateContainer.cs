using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLoadingNoteCreateContainer
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime Createdate { get; set; }

    public string? Notes { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Route { get; set; }

    public string? Routingset { get; set; }

    public string? Loadingseq { get; set; }

    public string Container { get; set; } = null!;

    public string? Hutype { get; set; }

    public string? Serial { get; set; }
}
