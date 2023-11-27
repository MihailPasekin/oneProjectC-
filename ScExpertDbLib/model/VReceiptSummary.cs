using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VReceiptSummary
{
    public string Receipt { get; set; } = null!;

    public int? NumLines { get; set; }

    public int? NumSkus { get; set; }

    public double? TotalWeight { get; set; }

    public double? TotalCube { get; set; }
}
