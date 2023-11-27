using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLocationHutypeContent
{
    public string Location { get; set; } = null!;

    public string CurrentHuType { get; set; } = null!;

    public int Currentqty { get; set; }

    public string PendingHutype { get; set; } = null!;

    public int Pendingqty { get; set; }

    public string? Putregion { get; set; }

    public string? Warehousearea { get; set; }
}
