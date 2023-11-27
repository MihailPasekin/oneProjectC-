using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingplanstrategy
{
    public string Policyid { get; set; } = null!;

    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Consignee { get; set; }

    public string? Ordertype { get; set; }

    public string? Companytype { get; set; }

    public string? Targetcompany { get; set; }

    public int Orderpriority { get; set; }

    public string? Route { get; set; }

    public double Fromordervalue { get; set; }

    public double Fromordervolume { get; set; }

    public double Fromorderweight { get; set; }

    public string? Companygroup { get; set; }

    public string Carrier { get; set; } = null!;

    public string Unloadingtype { get; set; } = null!;

    public string Vehicletype { get; set; } = null!;
}
