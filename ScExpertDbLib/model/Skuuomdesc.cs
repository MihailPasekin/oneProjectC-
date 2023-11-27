using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuuomdesc
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string? Description { get; set; }

    public string Loweruom { get; set; } = null!;
}
