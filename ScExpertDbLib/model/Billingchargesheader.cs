using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingchargesheader
{
    public string Chargeid { get; set; } = null!;

    public string Billingrunid { get; set; } = null!;

    public string? Agreementname { get; set; }

    public string Consignee { get; set; } = null!;

    public DateTime Billfromdate { get; set; }

    public DateTime Billtodate { get; set; }

    public string? Status { get; set; }

    public decimal Billtotal { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
