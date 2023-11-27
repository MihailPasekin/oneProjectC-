using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSkucode
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skucode { get; set; }
}
