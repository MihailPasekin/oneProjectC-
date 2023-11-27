using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileCld1
{
    public string Receipt { get; set; } = null!;

    public int Receiptline { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skucode { get; set; }

    public string Loadid { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Units { get; set; } = null!;

    public string Containerid { get; set; } = null!;

    public string Numloads { get; set; } = null!;

    public string? Printer { get; set; }

    public string? Uom { get; set; }

    public string? Status { get; set; }

    public string? Hutype { get; set; }

    public string? Hutrans { get; set; }

    public string? ReasonCode { get; set; }

    public string Spacer { get; set; } = null!;
}
