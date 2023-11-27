using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Warehousemapnode
{
    public string Nodeid { get; set; } = null!;

    public int Xcoordinate { get; set; }

    public int Ycoordinate { get; set; }

    public int? Zcoordinate { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
