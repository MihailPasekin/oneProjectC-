using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VParallelPickingDetail
{
    public string Parallelpickid { get; set; } = null!;

    public int Picklistseq { get; set; }

    public string PicksSortOrder { get; set; } = null!;

    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Pickregion { get; set; }

    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Status { get; set; }

    public string? Sku { get; set; }

    public string? Uom { get; set; }

    public decimal Qty { get; set; }

    public decimal Adjqty { get; set; }

    public decimal Pickedqty { get; set; }

    public string? Fromlocation { get; set; }

    public string? Fromload { get; set; }

    public string? Toload { get; set; }

    public string? Tocontainer { get; set; }

    public string? Tolocation { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
