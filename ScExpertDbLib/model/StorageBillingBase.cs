using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class StorageBillingBase
{
    public string Billingloadid { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public decimal? Units { get; set; }
}
