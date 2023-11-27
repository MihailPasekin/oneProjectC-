using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Pickheaderview
{
    public string Picklist { get; set; } = null!;

    public string Picktype { get; set; } = null!;

    public string Pickmethod { get; set; } = null!;

    public string Strategyid { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public DateTime? Plandate { get; set; }

    public DateTime? Releasedate { get; set; }

    public DateTime? Assigneddate { get; set; }

    public DateTime? Completeddate { get; set; }

    public string? Status { get; set; }

    public string? Wave { get; set; }

    public string? Handelingunittype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public int Picklistline { get; set; }

    public string? Pickregion { get; set; }

    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Sku { get; set; }

    public string? Parallelpickid { get; set; }

    public string? Handelingunit { get; set; }

    public string? Onhandlingunit { get; set; }

    public string? Userid { get; set; }
}
