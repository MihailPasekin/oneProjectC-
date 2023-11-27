using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteStop
{
    public int? Stopnumber { get; set; }

    public int? Stoptaskid { get; set; }

    public string? Stoptasktype { get; set; }

    public string? Stoptaskname { get; set; }

    public DateTime? Schedualeddate { get; set; }

    public string? Consignee { get; set; }

    public string? Documentid { get; set; }

    public string? Documenttype { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public string? Pointid { get; set; }

    public string? Packtype { get; set; }

    public int? Numpacks { get; set; }

    public string? Transportationclass { get; set; }

    public decimal? Stopdetvolume { get; set; }

    public decimal? Stopdetweight { get; set; }

    public string? Comments { get; set; }

    public decimal? Stopdetvalue { get; set; }

    public string? Status { get; set; }

    public DateTime? Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime? Editdate { get; set; }

    public string? Edituser { get; set; }

    public DateTime? Arrivaldate { get; set; }

    public DateTime? Departuredate { get; set; }

    public DateTime? Actualarrivaldate { get; set; }

    public DateTime? Actualdeparturedate { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? Companyname { get; set; }

    public string Runid { get; set; } = null!;

    public string? Routeset { get; set; }

    public string? Depo { get; set; }

    public string Routestatus { get; set; } = null!;

    public string? Routename { get; set; }

    public DateTime? Routedate { get; set; }

    public string? Startpoint { get; set; }

    public string? Endpoint { get; set; }

    public string? Vehicleid { get; set; }

    public string? Vehicletype { get; set; }

    public string? Driver { get; set; }

    public string? Territory { get; set; }

    public double? Routecost { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Actualstartdate { get; set; }

    public DateTime? Actualenddate { get; set; }

    public string? Strategyid { get; set; }

    public double? Totalvolume { get; set; }

    public double? Totalweight { get; set; }

    public string Routeid { get; set; } = null!;

    public int? NumberOfStops { get; set; }

    public int? NumberOfPackages { get; set; }

    public string? Staginglane { get; set; }

    public string? Referenceord { get; set; }

    public double? Distfromlaststop { get; set; }

    public double? Timefromlaststop { get; set; }

    public string? Confirmationlevel { get; set; }

    public bool? Allowpartialloading { get; set; }

    public bool? Allowpartialunloading { get; set; }

    public bool? Confirmpackageatunloading { get; set; }

    public bool? Allowpartialpickup { get; set; }

    public string? Confirmationtype { get; set; }

    public string? Confdocid { get; set; }

    public string? Reasoncode { get; set; }

    public string? Recipient { get; set; }

    public string? Confirmationnumber { get; set; }
}
