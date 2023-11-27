using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCancelLoadReceive
{
    public string? Document { get; set; }

    public int? Line { get; set; }

    public string? Loadid { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Uom { get; set; }

    public decimal? Receivedqty { get; set; }

    public string? Receivedstatus { get; set; }

    public string? Skudesc { get; set; }
}
