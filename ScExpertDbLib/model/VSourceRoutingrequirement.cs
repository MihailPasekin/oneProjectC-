using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSourceRoutingrequirement
{
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

    public string? Route { get; set; }

    public int Orderpriority { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public string Transportationclass { get; set; } = null!;

    public int Pallets { get; set; }

    public int Cases { get; set; }

    public double Orderweight { get; set; }

    public double Ordervolume { get; set; }

    public double Ordervalue { get; set; }

    public string DelType { get; set; } = null!;

    public string? Contactid { get; set; }

    public string Depot { get; set; } = null!;

    public string Chkpnt { get; set; } = null!;

    public string Chkpntpointid { get; set; } = null!;

    public string? Notes { get; set; }

    public double TotalOrderVolume { get; set; }

    public double TotalOrderWeight { get; set; }

    public int? ContactOpenHour { get; set; }

    public int? ContactCloseHour { get; set; }

    public string? Staginglane { get; set; }

    public string Documenttype { get; set; } = null!;

    public string Setid { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public DateTime? Plandate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? Distributiondate { get; set; }

    public string? Trip { get; set; }

    public int Currentindex { get; set; }

    public string? Activerunid { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
