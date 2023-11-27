using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLaborFromLocation
{
    public string FromLocation { get; set; } = null!;

    public string FromLocationAccessType { get; set; } = null!;

    public int FromLocationAccessibleLoads { get; set; }

    public bool FromLocationLoseid { get; set; }

    public string FromLocationAisle { get; set; } = null!;

    public int FromLocationLevel { get; set; }

    public double FromLocationHeightFromFloor { get; set; }

    public string FromLocationHufacing { get; set; } = null!;

    public string FromlocationInsertType { get; set; } = null!;

    public string FromLocationRetrieveType { get; set; } = null!;

    public string FromLocationPickType { get; set; } = null!;

    public string FromLocationReachType { get; set; } = null!;
}
