using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Pickloc
{
    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal? Currentqty { get; set; }

    public decimal? Pendingqty { get; set; }

    public decimal? Allocatedqty { get; set; }

    public decimal? Normalreplqty { get; set; }

    public decimal? Hotreplqty { get; set; }

    public decimal? Maximumqty { get; set; }

    public decimal? Overallocatedqty { get; set; }

    public string? Normalreplpolicy { get; set; }

    public string? Hotreplpolicy { get; set; }

    public decimal? Hotmaxreplqty { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
