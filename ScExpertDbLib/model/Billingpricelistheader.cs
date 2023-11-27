using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingpricelistheader
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Pricelisttype { get; set; } = null!;

    public bool? Isdaterange { get; set; }

    public bool? Active { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
