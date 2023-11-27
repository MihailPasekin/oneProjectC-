using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Outboundorheaderparam
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string? Paymentterms { get; set; }

    public decimal? Codamount { get; set; }

    public string? Codcurrency { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
