using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLaborSku
{
    public string Sku { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Scuclass { get; set; } = null!;

    public string SkutransportationClass { get; set; } = null!;

    public string SkuhazardClass { get; set; } = null!;
}
