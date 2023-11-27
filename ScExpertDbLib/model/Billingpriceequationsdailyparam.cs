using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingpriceequationsdailyparam
{
    public string Paramid { get; set; } = null!;

    public string Paramdescription { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
