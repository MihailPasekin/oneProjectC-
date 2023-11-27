using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Unroutedorder
{
    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public string? Ordertype { get; set; }

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Schedualeddate { get; set; }

    public string? Hutype { get; set; }

    public int? Huqty { get; set; }

    public string? Transportationclass { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Ordervalue { get; set; }

    public string? Status { get; set; }

    public string? Comments { get; set; }

    public string? Trip { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
