using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepPickingPlanShort
{
    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public int? Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Inventorystatus { get; set; }

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtyallocated { get; set; }

    public decimal? Qtypicked { get; set; }

    public decimal? Qtystaged { get; set; }

    public decimal? Qtyloaded { get; set; }

    public decimal? Qtyshipped { get; set; }
}
