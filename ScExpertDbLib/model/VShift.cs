﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShift
{
    public string Shiftid { get; set; } = null!;

    public string Shiftcode { get; set; } = null!;

    public string? Shiftdescription { get; set; }

    public string? Status { get; set; }

    public string Warehousearea { get; set; } = null!;

    public int? Scheduledstarttime { get; set; }

    public int? Scheduledendtime { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }
}
