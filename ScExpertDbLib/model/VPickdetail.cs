using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPickdetail
{
    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Pickregion { get; set; }

    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Status { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

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

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public string? Wave { get; set; }

    public string Picktype { get; set; } = null!;
}
