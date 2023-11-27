using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VBillingLoad
{
    public string Billingloadid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Skugroup { get; set; }

    public string? Uom { get; set; }

    public DateTime? Receivedate { get; set; }

    public DateTime? Shipdate { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public decimal Currentqty { get; set; }
}
