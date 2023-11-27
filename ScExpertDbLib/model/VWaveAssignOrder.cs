using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWaveAssignOrder
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime Createdate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Loadingseq { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public int? Orderpriority { get; set; }

    public string? Wave { get; set; }

    public string? Staginglane { get; set; }

    public string? Shipto { get; set; }

    public string? Hostorderid { get; set; }

    public string Doctype { get; set; } = null!;
}
