using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VConsolidationDetail
{
    public string Consolidateid { get; set; } = null!;

    public int Consolidateline { get; set; }

    public string? Fromload { get; set; }

    public string Fromlocation { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Loaduom { get; set; } = null!;

    public decimal Units { get; set; }

    public string? Containerid { get; set; }
}
