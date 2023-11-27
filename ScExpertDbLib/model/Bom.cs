using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Bom
{
    public string Consignee { get; set; } = null!;

    public string Bomsku { get; set; } = null!;

    public string Partsku { get; set; } = null!;

    public decimal? Partqty { get; set; }

    public string? Bomorder { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
