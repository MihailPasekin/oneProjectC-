using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Loadingplanview
{
    public string Planid { get; set; } = null!;

    public string Shipment { get; set; } = null!;

    public string Vehiclelocation { get; set; } = null!;

    public string? Handlingunit { get; set; }

    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public int? Qty { get; set; }

    public string? Picklist { get; set; }

    public int? Picklistline { get; set; }

    public string? Adduser { get; set; }

    public DateTime Adddate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Editdate { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }
}
