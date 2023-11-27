using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepDriverManifest
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public int Stopdetailid { get; set; }

    public string Stopdetailtype { get; set; } = null!;

    public string? Stopdetailname { get; set; }

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

    public string Status { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public DateTime? Arrivaldate { get; set; }

    public DateTime? Departuredate { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? Companyname { get; set; }

    public string? Routeset { get; set; }

    public string RouteStatus { get; set; } = null!;

    public string? Routename { get; set; }

    public DateTime? Routedate { get; set; }

    public double? Routecost { get; set; }

    public string? Vehicleid { get; set; }

    public string? Name { get; set; }

    public string? VehicleTypeDescription { get; set; }

    public string? Fullname { get; set; }

    public string Bill { get; set; } = null!;

    public int? NumStops { get; set; }
}
