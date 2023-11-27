using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingSetAvailableRequirement
{
    public string Requirementid { get; set; } = null!;

    public string Strategy { get; set; } = null!;

    public string Requirementtype { get; set; } = null!;

    public string Plantype { get; set; } = null!;

    public string? Pointid { get; set; }

    public string? Routingset { get; set; }

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Route { get; set; }

    public int? Orderpriority { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string Transportationclass { get; set; } = null!;

    public double Orderweight { get; set; }

    public double Ordervolume { get; set; }

    public string Deltype { get; set; } = null!;

    public string? Contactid { get; set; }

    public string Depot { get; set; } = null!;

    public string Chkpnt { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public double Ordervalue { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Contact1fax { get; set; }

    public string? Contact1email { get; set; }

    public string IsRouted { get; set; } = null!;

    public string Documenttype { get; set; } = null!;
}
