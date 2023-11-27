using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingsetUnassignedRequirement
{
    public string? Activerunid { get; set; }

    public string Routingset { get; set; } = null!;

    public int? Unassigned { get; set; }
}
