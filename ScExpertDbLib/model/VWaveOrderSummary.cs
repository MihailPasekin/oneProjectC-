using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWaveOrderSummary
{
    public string? Wave { get; set; }

    public int? NumOrders { get; set; }

    public int? NumOrderLines { get; set; }

    public double? TotalVolume { get; set; }

    public double? TotalWeight { get; set; }

    public int? NumExceptionLines { get; set; }

    public int? NumExceptionSku { get; set; }
}
