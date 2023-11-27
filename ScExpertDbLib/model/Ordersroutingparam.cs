using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Ordersroutingparam
{
    public string? Routingset { get; set; }

    public string Consignee { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Shipment { get; set; }

    public string? Staginglane { get; set; }

    public string? Route { get; set; }

    public double Ordervalue { get; set; }

    public double Ordervolume { get; set; }

    public double Orderweight { get; set; }

    public int Orderlines { get; set; }

    public decimal Orderunits { get; set; }

    public string Carrier { get; set; } = null!;

    public string Unloadingtype { get; set; } = null!;

    public string Vehicletype { get; set; } = null!;
}
