using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSerialManifest
{
    public string Consignee { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Orderid { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Sku { get; set; } = null!;

    public string? Serial { get; set; }

    public string? Invoice { get; set; }
}
