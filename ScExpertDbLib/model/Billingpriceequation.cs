using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingpriceequation
{
    public string Priceequationid { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Calculationequation { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
