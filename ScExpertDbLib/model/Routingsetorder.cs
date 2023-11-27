using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routingsetorder
{
    public string Setid { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public DateTime? Plandate { get; set; }

    public string Status { get; set; } = null!;

    public string? Trip { get; set; }

    public string? Consignee { get; set; }

    public string? Documentid { get; set; }

    public string? Documenttype { get; set; }

    public DateTime? Schedualeddate { get; set; }
}
