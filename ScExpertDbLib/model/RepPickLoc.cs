using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepPickLoc
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Location { get; set; } = null!;

    public string? Pickregion { get; set; }

    public decimal? Currentqty { get; set; }

    public decimal? Pendingqty { get; set; }

    public decimal? Allocatedqty { get; set; }

    public decimal? Normalreplqty { get; set; }

    public decimal? Hotreplqty { get; set; }

    public decimal? Maximumqty { get; set; }

    public decimal? Overallocatedqty { get; set; }
}
