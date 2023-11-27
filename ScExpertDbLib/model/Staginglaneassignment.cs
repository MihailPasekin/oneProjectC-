using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Staginglaneassignment
{
    public string Consignee { get; set; } = null!;

    public int Priority { get; set; }

    public string Documenttype { get; set; } = null!;

    public string? Ordertype { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public int? Frompriority { get; set; }

    public int? Topriority { get; set; }

    public string? Fromroute { get; set; }

    public string? Toroute { get; set; }

    public string? Fromdoor { get; set; }

    public string? Todoor { get; set; }

    public string? Carrier { get; set; }

    public string? Transmethod { get; set; }

    public string Fromstaginglane { get; set; } = null!;

    public string Tostaginglane { get; set; } = null!;

    public int Staginglaneinterval { get; set; }

    public string? Lastusedsl { get; set; }

    public string? Shipment { get; set; }
}
