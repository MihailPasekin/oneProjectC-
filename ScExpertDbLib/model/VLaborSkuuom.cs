using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLaborSkuuom
{
    public string Sku { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public double Uomweight { get; set; }

    public double Uomcube { get; set; }

    public string UompackageType { get; set; } = null!;

    public string UomgrabType { get; set; } = null!;

    public string UomlaborPreparationType { get; set; } = null!;

    public string UomlaborHandlingType { get; set; } = null!;
}
