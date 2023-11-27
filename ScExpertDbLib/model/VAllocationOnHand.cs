using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VAllocationOnHand
{
    public string? Wave { get; set; }

    public string? Orderid { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public decimal Onhandqty { get; set; }
}
