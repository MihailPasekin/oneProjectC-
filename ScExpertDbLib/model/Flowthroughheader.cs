using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Flowthroughheader
{
    public string Consignee { get; set; } = null!;

    public string Flowthrough { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Sourcecompany { get; set; } = null!;

    public string? Sourcecompanytype { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Targetcompanytype { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Notes { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Scheduledarrivaldate { get; set; }

    public DateTime? Requesteddeliverydate { get; set; }

    public DateTime? Scheduleddeliverydate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Staginglane { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Loadingseq { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public string? Deliverystatus { get; set; }

    public string? Pod { get; set; }

    public int? Orderpriority { get; set; }

    public string? Receivedfrom { get; set; }

    public string? Shipto { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
