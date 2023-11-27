using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingadditional
{
    public string Tranid { get; set; } = null!;

    public string Trantype { get; set; } = null!;

    public string? Reftranid { get; set; }

    public string? Status { get; set; }

    public string Consignee { get; set; } = null!;

    public decimal Units { get; set; }

    public string Unitstype { get; set; } = null!;

    public string? Amount { get; set; }

    public bool Istotalamount { get; set; }

    public double Price { get; set; }

    public DateTime Trandate { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
