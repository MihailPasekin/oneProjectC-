using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Counting
{
    public string Countid { get; set; } = null!;

    public string Counttype { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Loadid { get; set; }

    public string? Location { get; set; }

    public string? Countbook { get; set; }

    public string? Countbookrunid { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
