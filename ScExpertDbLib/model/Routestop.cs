using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routestop
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public string? Status { get; set; }

    public string? Stopname { get; set; }

    public string? Pointid { get; set; }

    public DateTime? Arrivaldate { get; set; }

    public DateTime? Departuredate { get; set; }

    public DateTime? Actualarrivaldate { get; set; }

    public DateTime? Actualdeparturedate { get; set; }

    public double? Timefromlaststop { get; set; }

    public double? Distfromlaststop { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
