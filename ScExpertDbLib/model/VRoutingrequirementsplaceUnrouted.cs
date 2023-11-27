using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingrequirementsplaceUnrouted
{
    public string ReqId { get; set; } = null!;

    public string Runid { get; set; } = null!;

    public string Pdtype { get; set; } = null!;

    public string Pointid { get; set; } = null!;

    public string Routingset { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companygroup { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Route { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string Transportationclass { get; set; } = null!;

    public double Orderweight { get; set; }

    public double Ordervolume { get; set; }

    public string? Contactid { get; set; }
}
