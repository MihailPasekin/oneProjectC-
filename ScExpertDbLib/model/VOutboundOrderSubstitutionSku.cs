using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOutboundOrderSubstitutionSku
{
    public string? Wave { get; set; }

    public string? Orderid { get; set; }

    public string? Consignee { get; set; }

    public string? Originalsku { get; set; }

    public string? Sku { get; set; }

    public string? Skuabove { get; set; }

    public int? Level { get; set; }

    public string? Inventorystatus { get; set; }
}
