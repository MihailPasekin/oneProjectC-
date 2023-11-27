using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Packinglistheader
{
    public string Packinglistid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? Numpackages { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
