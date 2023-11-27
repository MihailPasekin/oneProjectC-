using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingAssignRequirement
{
    public string Stopnumber { get; set; } = null!;

    public string? Activerunid { get; set; }

    public string Chkpnt { get; set; } = null!;

    public string Strategy { get; set; } = null!;

    public string Pdtype { get; set; } = null!;

    public string? Pointid { get; set; }

    public string Routingset { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companygroup { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Staginglane { get; set; }

    public string? Route { get; set; }

    public int Orderpriority { get; set; }

    public double Ordervalue { get; set; }

    public double Ordervolume { get; set; }

    public double Orderweight { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string? Contactid { get; set; }

    public string Transportationclass { get; set; } = null!;
}
