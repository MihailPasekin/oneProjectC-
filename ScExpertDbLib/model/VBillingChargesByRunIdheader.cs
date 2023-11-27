using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VBillingChargesByRunIdheader
{
    public string Billingrunid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Agreementname { get; set; }

    public string? Description { get; set; }

    public string Period { get; set; } = null!;

    public string Periodtype { get; set; } = null!;

    public DateTime? Billfromdate { get; set; }

    public DateTime? Billtodate { get; set; }

    public decimal? Billtotal { get; set; }
}
