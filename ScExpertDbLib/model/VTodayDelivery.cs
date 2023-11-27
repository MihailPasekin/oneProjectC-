using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VTodayDelivery
{
    public DateTime? RoutesDate { get; set; }

    public int? Totalroutes { get; set; }

    public int? TotalStops { get; set; }

    public int? Totaltasks { get; set; }

    public int CompletedTasks { get; set; }
}
