﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileCnttask1
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Location { get; set; } = null!;

    public string Spacer { get; set; } = null!;

    public string? Uom { get; set; }

    public string Tounits { get; set; } = null!;

    public string Tolocation { get; set; } = null!;
}
