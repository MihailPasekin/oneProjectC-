using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Containerorder
{
    public string Container { get; set; } = null!;

    public string? Type { get; set; }

    public string? Orderid { get; set; }

    public string? Consignee { get; set; }
}
