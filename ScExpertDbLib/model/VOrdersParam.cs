using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VOrdersParam
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string? Wave { get; set; }

    public string Ordertype { get; set; } = null!;

    public double Ordervalue { get; set; }

    public double Ordervolume { get; set; }

    public double Orderweight { get; set; }

    public int Orderlines { get; set; }
}
