using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Compservicetime
{
    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public int Priority { get; set; }

    public int? Sunopen { get; set; }

    public int? Sunclose { get; set; }

    public int? Monopen { get; set; }

    public int? Monclose { get; set; }

    public int? Tueopen { get; set; }

    public int? Tueclose { get; set; }

    public int? Wedopen { get; set; }

    public int? Wedclose { get; set; }

    public int? Thuopen { get; set; }

    public int? Thuclose { get; set; }

    public int? Friopen { get; set; }

    public int? Friclose { get; set; }

    public int? Satopen { get; set; }

    public int? Satclose { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
