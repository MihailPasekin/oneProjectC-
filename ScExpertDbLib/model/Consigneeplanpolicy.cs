using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Consigneeplanpolicy
{
    public int Planpolicyid { get; set; }

    public string Consignee { get; set; } = null!;

    public int Priority { get; set; }

    public string? Ordertype { get; set; }

    public string? Classname { get; set; }

    public string? Sku { get; set; }

    public string? Velocity { get; set; }

    public string? Skugroup { get; set; }

    public string? Companytype { get; set; }

    public string? Route { get; set; }

    public double? Fromordervalue { get; set; }

    public double? Toordervalue { get; set; }

    public double? Fromordervolume { get; set; }

    public double? Toordervolume { get; set; }

    public double? Fromorderweight { get; set; }

    public double? Toorderweight { get; set; }

    public double? Fromorderlineweight { get; set; }

    public double? Toorderlineweight { get; set; }

    public string Policyid { get; set; } = null!;

    public int? Orderpriority { get; set; }

    public string? Targetcompany { get; set; }

    public string? Companygroup { get; set; }

    public decimal? Fromlineunits { get; set; }

    public decimal? Tolineunits { get; set; }

    public decimal? Fromlinevalue { get; set; }

    public decimal? Tolinevalue { get; set; }

    public double? Fromlinevolume { get; set; }

    public double? Tolinevolume { get; set; }

    public string? Invstatus { get; set; }

    public decimal? Fromorderunits { get; set; }

    public decimal? Toorderunits { get; set; }

    public double? Fromorderlines { get; set; }

    public double? Toorderlines { get; set; }

    public string? Carrier { get; set; }

    public string? Unloadingtype { get; set; }

    public string? Vehicletype { get; set; }

    public string? Transporttype { get; set; }

    public string? Hazclass { get; set; }

    public decimal? Drivingtimefactor { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
