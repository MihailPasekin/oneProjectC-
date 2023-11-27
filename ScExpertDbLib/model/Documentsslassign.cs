using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Documentsslassign
{
    public string Consignee { get; set; } = null!;

    public string Doctype { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Staginglane { get; set; }

    public string? Status { get; set; }

    public double Ordervolume { get; set; }

    public double Orderweight { get; set; }

    public string Company { get; set; } = null!;

    public string? Companytype { get; set; }

    public string Route { get; set; } = null!;

    public int? Orderpriority { get; set; }

    public string Door { get; set; } = null!;

    public string Carrier { get; set; } = null!;

    public string Transporttype { get; set; } = null!;

    public string Shipment { get; set; } = null!;
}
