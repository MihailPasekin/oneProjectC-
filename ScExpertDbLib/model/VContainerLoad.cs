using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VContainerLoad
{
    public string Container { get; set; } = null!;

    public string? Hutype { get; set; }

    public string? Oncontainer { get; set; }

    public string? Usagetype { get; set; }

    public string? Serial { get; set; }

    public string? Destinationlocation { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Status { get; set; }

    public string Activitystatus { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal Unitsavailable { get; set; }

    public string? Consigneename { get; set; }

    public string? Location { get; set; }

    public int? Numloads { get; set; }
}
