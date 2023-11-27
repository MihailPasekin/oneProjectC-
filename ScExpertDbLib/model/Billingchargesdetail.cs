using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingchargesdetail
{
    public string Chargeid { get; set; } = null!;

    public int Chargeline { get; set; }

    public int Agreementline { get; set; }

    public decimal Units { get; set; }

    public double Billtotal { get; set; }

    public string? Agreementname { get; set; }

    public string? Status { get; set; }

    public string? Chargetext { get; set; }

    public DateTime Billfromdate { get; set; }

    public DateTime Billtodate { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
