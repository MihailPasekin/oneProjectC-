﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOutboundOrderHeader
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Ordertypedesc { get; set; }

    public string? Referenceord { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public string? Statusdesc { get; set; }

    public DateTime Createdate { get; set; }

    public string? Notes { get; set; }

    public string? Staginglane { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string Wave { get; set; } = null!;

    public DateTime? Statusdate { get; set; }

    public string? Loadingseq { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public string? Deliverystatus { get; set; }

    public string? Pod { get; set; }

    public int? Orderpriority { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public string? Shipto { get; set; }

    public double? Ordervolume { get; set; }

    public double? Orderweight { get; set; }

    public string Pointid { get; set; } = null!;
}
