using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOutboundorderLoad
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public int Orderline { get; set; }

    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public decimal Units { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? PickContainer { get; set; }

    public string? Hutype { get; set; }

    public string? Usagetype { get; set; }

    public string? Serial { get; set; }

    public string? Status { get; set; }

    public int Toqty { get; set; }

    public string Container { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Location { get; set; } = null!;

    public string? Activitystatus { get; set; }
}
