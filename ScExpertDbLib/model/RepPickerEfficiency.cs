using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepPickerEfficiency
{
    public string? Userid { get; set; }

    public string? Fullname { get; set; }

    public int GroupCode { get; set; }

    public string GroupName { get; set; } = null!;

    public DateTime? Activitydate { get; set; }

    public int? Skucount { get; set; }

    public int? Numrows { get; set; }
}
