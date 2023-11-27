using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLoadCycleCountNumLoad
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public int? Skuccint { get; set; }

    public int? Consigneeccint { get; set; }

    public int? Ccint { get; set; }

    public int? TotalNumLoad { get; set; }

    public decimal? NumLoadPerRun { get; set; }
}
