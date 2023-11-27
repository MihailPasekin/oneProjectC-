using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPackingList
{
    public string Packinglistid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? Numpackages { get; set; }

    public string Loadid { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Location { get; set; } = null!;

    public string Loadstatus { get; set; } = null!;

    public decimal Units { get; set; }

    public string? Loadactivitystatus { get; set; }

    public string? Handlingunit { get; set; }

    public string? HandlingUnitType { get; set; }
}
