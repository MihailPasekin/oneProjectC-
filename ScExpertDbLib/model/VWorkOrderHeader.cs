using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWorkOrderHeader
{
    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Ordertypedesc { get; set; }

    public string Documenttype { get; set; } = null!;

    public string? Documenttypedesc { get; set; }

    public string? Referenceord { get; set; }

    public string? Referenceordline { get; set; }

    public string? Outboundorder { get; set; }

    public int? Outboundorderline { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Inventorystatus { get; set; }

    public string? Inventorystatusdesc { get; set; }

    public decimal? Originalqty { get; set; }

    public decimal? Modifiedqty { get; set; }

    public decimal? Plannedqty { get; set; }

    public decimal? Completedqty { get; set; }

    public string Location { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public DateTime? Releasedate { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Closedate { get; set; }

    public string? Notes { get; set; }

    public string Status { get; set; } = null!;

    public string? Statusdesc { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
