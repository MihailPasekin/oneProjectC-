using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routingstrategydetail
{
    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Routenameprefix { get; set; }

    public int? Numtripsperday { get; set; }

    public string? Territoryset { get; set; }

    public int? Starttimeatdepo { get; set; }

    public double? Minservicetime { get; set; }

    public int? Maxstopsperroute { get; set; }

    public double? Maxtimeperroute { get; set; }

    public double? Maxdistanceperroute { get; set; }

    public double? Maxdistancebetweenstops { get; set; }

    public double? Maxtimebetweenstops { get; set; }

    public double? Maxdistancebetweendeliveryandpickup { get; set; }

    public double? Maxadditionaldistanceperroute { get; set; }

    public int? Clustersize { get; set; }

    public double? Minclustersize { get; set; }

    public double? Maxclustersize { get; set; }

    public int? Minclustersizeformerge { get; set; }

    public int? Latesttimestartdepot { get; set; }

    public bool? Calcretfromlaststop { get; set; }

    public bool? Calcrettofirststop { get; set; }

    public int? Openhoursmisspenalty { get; set; }

    public string? Servicetimeequation { get; set; }

    public string? Routecostequation { get; set; }

    public int? Routecostfactor { get; set; }

    public int? Numvehiclefactor { get; set; }

    public int? Allowsplitorder { get; set; }

    public int? Allowsplitcontact { get; set; }

    public int? Allowsplitstop { get; set; }

    public int Allowedtimebeforeopen { get; set; }

    public int Allowcontinueroute { get; set; }

    public decimal? Allowedoverweightforlaststop { get; set; }

    public decimal? Allowedovervolumeforlaststop { get; set; }

    public double? Allowpickupbeforedelivery { get; set; }

    public double? Minrouteweight { get; set; }

    public double? Minroutevolume { get; set; }

    public double? Targetfillweight { get; set; }

    public double? Targetfillvolume { get; set; }

    public string? Defaultvehicletype { get; set; }

    public int? Continueroutewithreq { get; set; }

    public int? DepotReloadTime { get; set; }

    public int? TotalTripsAllocationTime { get; set; }

    public int? TotalTripsAllocationDistance { get; set; }

    public double? DistanceForSplitStop { get; set; }

    public decimal? DistanceJoinStopCluster { get; set; }

    public string? ChkPntPositionType { get; set; }

    public double? Minpctweighttosplit { get; set; }

    public double? Minpctvolumetosplit { get; set; }

    public double? Minweighttosplit { get; set; }

    public double? Minvolumetosplit { get; set; }

    public double? Maxpctweighttrucktosplit { get; set; }

    public double? Maxpctvolumetrucktosplit { get; set; }

    public bool? Routefarclustersfirst { get; set; }

    public int? Maximizetripspervehicle { get; set; }

    public string? Clustertype { get; set; }

    public bool Replanclusterremainders { get; set; }

    public string? Startpoint { get; set; }

    public string? Endpoint { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Vehicleallocationmode { get; set; }
}
