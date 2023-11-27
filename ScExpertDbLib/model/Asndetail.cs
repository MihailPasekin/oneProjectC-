using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asndetail
{
    public string Asnid { get; set; } = null!;

    public string Receipt { get; set; } = null!;

    public int Receiptline { get; set; }

    public string Container { get; set; } = null!;

    public string? Loadid { get; set; }

    public string Uom { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal? Units { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
