using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mapnetwork
{
    public int Pointid { get; set; }

    public int Nextpointid { get; set; }

    public int? Drivingtime { get; set; }

    public int? Drivingdist { get; set; }

    public bool Isoneway { get; set; }

    public string? Roadname { get; set; }

    public int? Averagespeed { get; set; }

    public DateTime? Rushamfrom { get; set; }

    public DateTime? Rushamto { get; set; }

    public DateTime? Rushpmfrom { get; set; }

    public DateTime? Rushpmto { get; set; }

    public int? RushFactor { get; set; }

    public double? Toll { get; set; }

    public string? Roadtype { get; set; }

    public string? Roaddirection { get; set; }

    public int? Neighborsradius { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
