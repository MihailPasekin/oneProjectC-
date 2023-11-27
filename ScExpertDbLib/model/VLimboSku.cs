using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLimboSku
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }
}
