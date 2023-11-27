using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routingplanstrategy
{
    public int Planstrategyid { get; set; }

    public int Priority { get; set; }

    public string? Consignee { get; set; }

    public string? Ordertype { get; set; }

    public string? Companytype { get; set; }

    public string? Route { get; set; }

    public double? Ordervalue { get; set; }

    public double? Ordervolume { get; set; }

    public double? Orderweight { get; set; }

    public int? Orderpriority { get; set; }

    public string? Targetcompany { get; set; }

    public string? Companygroup { get; set; }

    public string? Carrier { get; set; }

    public string? Unloadingtype { get; set; }

    public string? Vehicletype { get; set; }

    public string Strategyid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
