using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Loadingpolicieslookup
{
    public string Vehicletype { get; set; } = null!;

    public string Carrier { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Ordertype { get; set; }

    public string? Sku { get; set; }

    public string? Skugroup { get; set; }

    public string? Loadingplanpolicy { get; set; }

    public int? Priority { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
