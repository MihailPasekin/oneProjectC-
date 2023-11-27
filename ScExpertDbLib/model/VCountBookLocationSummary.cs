using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCountBookLocationSummary
{
    public string Countbook { get; set; } = null!;

    public string Countbookrunid { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal? Expectedqty { get; set; }

    public decimal? Countqty { get; set; }

    public string? Skudesc { get; set; }

    public string? Sku { get; set; }

    public string? Consignee { get; set; }
}
