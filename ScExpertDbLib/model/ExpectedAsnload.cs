using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class ExpectedAsnload
{
    public string Receipt { get; set; } = null!;

    public int Receiptline { get; set; }

    public string Asnid { get; set; } = null!;

    public string? Loadid { get; set; }

    public string Container { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public DateTime? Scheduleddate { get; set; }

    public string? Bol { get; set; }

    public string Huid { get; set; } = null!;

    public string? Transporttype { get; set; }

    public string? Transportreference { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal? Units { get; set; }

    public string Status { get; set; } = null!;

    public string Consignee { get; set; } = null!;
}
