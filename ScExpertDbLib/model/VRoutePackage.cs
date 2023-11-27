using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutePackage
{
    public string Packageid { get; set; } = null!;

    public string Packagetype { get; set; } = null!;

    public string Documenttype { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Documentid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Statusdate { get; set; }

    public string? Routeid { get; set; }

    public int? Stopnumber { get; set; }

    public int? Stoptaskid { get; set; }

    public string? RouteStatus { get; set; }

    public string Vehicleid { get; set; } = null!;

    public string? Vehicletype { get; set; }

    public string Driver { get; set; } = null!;

    public DateTime? Routedate { get; set; }
}
