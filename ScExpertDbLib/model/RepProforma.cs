using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepProforma
{
    public string Chargeid { get; set; } = null!;

    public string Billingrunid { get; set; } = null!;

    public string? Agreementname { get; set; }

    public string Consignee { get; set; } = null!;

    public DateTime Billfromdate { get; set; }

    public DateTime Billtodate { get; set; }

    public int Chargeline { get; set; }

    public int Agreementline { get; set; }

    public string Trantype { get; set; } = null!;

    public string Billbasis { get; set; } = null!;

    public decimal Units { get; set; }

    public double Billtotal { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;
}
