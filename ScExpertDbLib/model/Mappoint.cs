using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mappoint
{
    public string Pointid { get; set; } = null!;

    public string? Shortname { get; set; }

    public string? Pointtypeid { get; set; }

    public string? TimeZone { get; set; }

    public string? CountryCode { get; set; }

    public string? Comments { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double? Lon { get; set; }

    public double? Lat { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
