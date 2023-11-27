using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingpricelistdetail
{
    public string Pricelistname { get; set; } = null!;

    public int Line { get; set; }

    public decimal Minunits { get; set; }

    public decimal Maxunits { get; set; }

    public double Price { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
