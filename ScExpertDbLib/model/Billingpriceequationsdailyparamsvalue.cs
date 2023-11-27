using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingpriceequationsdailyparamsvalue
{
    public string Paramid { get; set; } = null!;

    public string? Paramvalue { get; set; }

    public DateTime Paramdate { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
