using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShowRouteInfoDetail
{
    public string Routeid { get; set; } = null!;

    public double? Routecost { get; set; }

    public double Totaldistance { get; set; }

    public decimal Totaltime { get; set; }

    public double Totalweight { get; set; }

    public double Totalvolume { get; set; }

    public string Vehicletype { get; set; } = null!;

    public string Vehicleid { get; set; } = null!;

    public string Driver { get; set; } = null!;

    public string Function1 { get; set; } = null!;
}
