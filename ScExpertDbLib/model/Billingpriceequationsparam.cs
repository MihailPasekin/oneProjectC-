using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingpriceequationsparam
{
    public string Paramid { get; set; } = null!;

    public string Paramdescription { get; set; } = null!;

    public string? Paramvalue { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
