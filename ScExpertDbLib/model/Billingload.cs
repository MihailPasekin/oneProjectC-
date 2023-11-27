using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingload
{
    public string Loadid { get; set; } = null!;

    public string Billingloadid { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Uom { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Lastdate { get; set; }

    public decimal? Currentqty { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
