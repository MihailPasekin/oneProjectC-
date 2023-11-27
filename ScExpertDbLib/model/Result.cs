using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Result
{
    public int StopId { get; set; }

    public string? Nickname { get; set; }

    public string? StopStatus { get; set; }

    public string? StopType { get; set; }

    public string? StopName { get; set; }

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? PhoneNumber { get; set; }

    public string? TimeZone { get; set; }

    public string? CountryCode { get; set; }

    public int? TerritoryId { get; set; }

    public float? RushFactor { get; set; }

    public string? UnloadSide { get; set; }

    public string? Comments { get; set; }

    public int? Latitude { get; set; }

    public int? Longitude { get; set; }

    public float? SetupMin { get; set; }

    public bool OrderSplitting { get; set; }

    public string? RoadType { get; set; }

    public short? LatKey { get; set; }

    public short? LonKey { get; set; }

    public short? LocationMethod { get; set; }
}
