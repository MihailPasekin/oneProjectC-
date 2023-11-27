using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Drivertaskstran
{
    public string Drivertaskid { get; set; } = null!;

    public string Drivertasktype { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? Statusdate { get; set; }

    public decimal? Stdtime { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
