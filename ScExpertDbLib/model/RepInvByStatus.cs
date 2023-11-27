using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepInvByStatus
{
    public string Status { get; set; } = null!;

    public string? Statusdesc { get; set; }

    public string? Skugroup { get; set; }

    public string? Skuclass { get; set; }

    public string? Skuclassdesc { get; set; }

    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal? Units { get; set; }

    public decimal? Unitsallocated { get; set; }

    public decimal? Unitsinprocess { get; set; }

    public decimal? Unitspicked { get; set; }
}
