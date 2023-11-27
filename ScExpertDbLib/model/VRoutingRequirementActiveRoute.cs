using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingRequirementActiveRoute
{
    public string? Consignee { get; set; }

    public string? Documentid { get; set; }

    public string Routeid { get; set; } = null!;

    public string? Routeset { get; set; }

    public string Routed { get; set; } = null!;

    public string? Vehicletype { get; set; }

    public string? Vehicleid { get; set; }

    public string? Driver { get; set; }

    public string? Fullname { get; set; }

    public string? Routestatus { get; set; }
}
