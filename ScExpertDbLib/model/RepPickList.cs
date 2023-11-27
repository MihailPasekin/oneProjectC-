using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepPickList
{
    public string Picklist { get; set; } = null!;

    public string? Picktype { get; set; }

    public string? Pickmethod { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Plandate { get; set; }

    public int Picklistline { get; set; }

    public string? Pickregion { get; set; }

    public DateTime? Releasedate { get; set; }

    public DateTime? Assigneddate { get; set; }

    public DateTime? Completeddate { get; set; }

    public string? Wave { get; set; }

    public string? Handelingunittype { get; set; }

    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Status { get; set; }

    public string? Uom { get; set; }

    public decimal Qty { get; set; }

    public decimal Adjqty { get; set; }

    public decimal Pickedqty { get; set; }

    public string? Fromlocation { get; set; }

    public string? Fromload { get; set; }

    public string? Toload { get; set; }

    public string? Tocontainer { get; set; }

    public string? Tolocation { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Companyname { get; set; }
}
