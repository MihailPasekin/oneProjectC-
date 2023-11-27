using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSkuSubstitute
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public decimal Skuqty { get; set; }

    public string Substitutesku { get; set; } = null!;

    public decimal Substituteskuqty { get; set; }

    public string Substitutiontype { get; set; } = null!;

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public int Priority { get; set; }

    public bool Multilevel { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Skudesc { get; set; }
}
