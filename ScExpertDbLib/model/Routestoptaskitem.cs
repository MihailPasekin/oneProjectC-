using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routestoptaskitem
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public int Stoptaskid { get; set; }

    public string Item { get; set; } = null!;

    public string? Itemdesc { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Qtyconfirmed { get; set; }

    public string Uom { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? Reasoncode { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
