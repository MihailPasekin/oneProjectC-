using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCountBook
{
    public string Countbook { get; set; } = null!;

    public string Countbookrunid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public DateTime? Closedate { get; set; }

    public string? Note { get; set; }

    public int? TotalCountTasks { get; set; }

    public int? CompletedCountTasks { get; set; }

    public int? OpenCountTasks { get; set; }

    public string? Counttype { get; set; }
}
