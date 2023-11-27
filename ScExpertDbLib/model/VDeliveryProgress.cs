using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDeliveryProgress
{
    public string Routename { get; set; } = null!;

    public string Routeid { get; set; } = null!;

    public string? Routedate { get; set; }

    public string? Status { get; set; }

    public int? Taskcount { get; set; }
}
