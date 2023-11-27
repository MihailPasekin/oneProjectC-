using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class ShipmentAssignOrder
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Sourcecompany { get; set; } = null!;

    public string? Sourcecomapnyname { get; set; }

    public string? Sourcecompanytype { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Targetcompanyname { get; set; }

    public string? Targetcompanytype { get; set; }

    public string? Status { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Loadingseq { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public int? Orderpriority { get; set; }

    public string? Wave { get; set; }

    public string Doctype { get; set; } = null!;
}
