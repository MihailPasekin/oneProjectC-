using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LoadUom
{
    public string? Description { get; set; }

    public string Uom { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Codelistcode { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Consignee { get; set; } = null!;
}
