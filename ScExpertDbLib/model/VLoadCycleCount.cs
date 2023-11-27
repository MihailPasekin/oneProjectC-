using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLoadCycleCount
{
    public long? RowNum { get; set; }

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string Skugroup { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime Lastcountdate { get; set; }

    public int? Ccint { get; set; }

    public decimal? NumLoadPerRun { get; set; }
}
