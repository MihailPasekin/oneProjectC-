using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Pointscluster
{
    public long Runid { get; set; }

    public string Pointid { get; set; } = null!;

    public int Clusternum { get; set; }

    public int Pointnum { get; set; }

    public long? Clustertype { get; set; }

    public DateTime Adddate { get; set; }
}
