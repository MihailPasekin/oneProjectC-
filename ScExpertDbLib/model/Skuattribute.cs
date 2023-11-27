using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuattribute
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public int? Shelflife { get; set; }

    public int? Shortlifedays { get; set; }
}
