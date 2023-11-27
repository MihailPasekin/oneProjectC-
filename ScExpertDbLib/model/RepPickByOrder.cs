﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepPickByOrder
{
    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Wave { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public decimal Qty { get; set; }

    public decimal Adjqty { get; set; }

    public decimal Pickedqty { get; set; }

    public string? Fromlocation { get; set; }

    public string? Fromload { get; set; }

    public string? Toload { get; set; }

    public string? Tolocation { get; set; }

    public string? Skudesc { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companyname { get; set; }
}
