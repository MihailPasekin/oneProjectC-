using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileReceiveById1
{
    public string Asnid { get; set; } = null!;

    public string ContainerId { get; set; } = null!;

    public string? Loadid { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? SkuDesc { get; set; }

    public string Receipt { get; set; } = null!;

    public string? Bol { get; set; }

    public int ReceiptLine { get; set; }

    public string Uom { get; set; } = null!;

    public string? Uomdesc { get; set; }

    public decimal? Units { get; set; }

    public string Spacer1 { get; set; } = null!;

    public string Container { get; set; } = null!;

    public string? Hutype { get; set; }

    public string? Usagetype { get; set; }

    public string Location { get; set; } = null!;

    public string Spacer2 { get; set; } = null!;
}
