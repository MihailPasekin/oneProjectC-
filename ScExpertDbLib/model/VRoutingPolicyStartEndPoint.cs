using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingPolicyStartEndPoint
{
    public string Contactid { get; set; } = null!;

    public string? Pointid { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }
}
