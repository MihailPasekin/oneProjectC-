using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLaborToLocation
{
    public string ToLocation { get; set; } = null!;

    public string ToLocationAccessType { get; set; } = null!;

    public int ToLocationAccessibleLoads { get; set; }

    public bool ToLocationLoseid { get; set; }

    public string ToLocationAisle { get; set; } = null!;

    public int ToLocationLevel { get; set; }

    public double ToLocationHeightFromFloor { get; set; }

    public string ToLocationHufacing { get; set; } = null!;

    public string ToLocationInsertType { get; set; } = null!;

    public string ToLocationRetrieveType { get; set; } = null!;

    public string ToLocationPickType { get; set; } = null!;

    public string ToLocationReachType { get; set; } = null!;
}
