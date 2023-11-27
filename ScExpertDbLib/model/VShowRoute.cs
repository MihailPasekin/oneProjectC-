using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShowRoute
{
    public string Routeid { get; set; } = null!;

    public string Runid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Routeset { get; set; }

    public string? Depo { get; set; }

    public string? Routename { get; set; }

    public DateTime? Routedate { get; set; }

    public string? Startpoint { get; set; }

    public string? Endpoint { get; set; }

    public string? Vehicleid { get; set; }

    public string? Vehicletype { get; set; }

    public string? Driver { get; set; }

    public string? Territory { get; set; }

    public decimal? Routecost { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public double? Totaldistance { get; set; }

    public decimal? Totaltime { get; set; }

    public double? Totalvolume { get; set; }

    public double? Totalweight { get; set; }

    public string? Strategyid { get; set; }

    public string? Distround { get; set; }

    public string? Territoryset { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Actualstartdate { get; set; }

    public DateTime? Actualenddate { get; set; }

    public string? TripGroup { get; set; }

    public int? TripNum { get; set; }

    public decimal Vehiclevolume { get; set; }

    public decimal Vehicleweight { get; set; }

    public int? ProgressVolume { get; set; }

    public int? ProgressWeight { get; set; }

    public int? NumStops { get; set; }
}
