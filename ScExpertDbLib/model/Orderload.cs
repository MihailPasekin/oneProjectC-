using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Orderload
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public int Orderline { get; set; }

    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Documenttype { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
