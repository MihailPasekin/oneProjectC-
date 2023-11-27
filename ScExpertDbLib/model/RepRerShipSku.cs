using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepRerShipSku
{
    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public decimal Retqty { get; set; }

    public decimal Shipqty { get; set; }
}
