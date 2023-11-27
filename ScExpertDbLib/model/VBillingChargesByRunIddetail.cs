using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VBillingChargesByRunIddetail
{
    public string Billingrunid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Agreementname { get; set; }

    public string Chargeid { get; set; } = null!;

    public int Chargeline { get; set; }

    public int Agreementline { get; set; }

    public DateTime Billfromdate { get; set; }

    public DateTime Billtodate { get; set; }

    public double Billtotal { get; set; }

    public string? Status { get; set; }

    public decimal Units { get; set; }

    public string? Chargetext { get; set; }
}
