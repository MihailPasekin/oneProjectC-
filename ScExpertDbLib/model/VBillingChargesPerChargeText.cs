using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VBillingChargesPerChargeText
{
    public string Agreementname { get; set; } = null!;

    public string? Chargetext { get; set; }

    public double Billtotal { get; set; }

    public string? Status { get; set; }

    public DateTime Editdate { get; set; }
}
