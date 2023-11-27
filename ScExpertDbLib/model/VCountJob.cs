using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCountJob
{
    public string Countid { get; set; } = null!;

    public string Counttype { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Consigneename { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Loadid { get; set; }

    public string? Location { get; set; }

    public string? Aisle { get; set; }

    public string? Bay { get; set; }

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string? Countbook { get; set; }

    public string? Countbookrunid { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
