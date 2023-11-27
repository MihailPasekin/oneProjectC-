using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Outordertypeparam
{
    public bool Direct { get; set; }

    public string Custtype { get; set; } = null!;

    public int Fromcases { get; set; }

    public int Tocases { get; set; }

    public bool Hasroute { get; set; }

    public string Ordertype { get; set; } = null!;

    public int? Priority { get; set; }
}
