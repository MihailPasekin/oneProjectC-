using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOrdersAutomationWaveAssign
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public int? Orderpriority { get; set; }

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public string Staginglane { get; set; } = null!;

    public string Route { get; set; } = null!;

    public string Shipment { get; set; } = null!;

    public string Door { get; set; } = null!;

    public string Carrier { get; set; } = null!;

    public string Transporttype { get; set; } = null!;

    public DateTime? Requesteddate { get; set; }

    public double Ordervolume { get; set; }
}
