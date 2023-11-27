using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VYardGatesActivityAudit
{
    public string Auditid { get; set; } = null!;

    public string? Userid { get; set; }

    public DateTime? Activitydate { get; set; }

    public string? Activitytype { get; set; }

    public string? Fromstatus { get; set; }

    public string? Tostatus { get; set; }

    public string? Fromloc { get; set; }

    public string? Toloc { get; set; }

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Yardlocation { get; set; }

    public string? Tagnumber { get; set; }
}
