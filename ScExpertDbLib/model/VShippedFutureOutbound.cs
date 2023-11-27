using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShippedFutureOutbound
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? Date { get; set; }
}
