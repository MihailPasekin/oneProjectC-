using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VContainerContent
{
    public string? Container { get; set; }

    public string? Hutype { get; set; }

    public string? Oncontainer { get; set; }

    public string? Location { get; set; }

    public string? Destinationlocation { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Usagetype { get; set; }

    public string? Serial { get; set; }

    public string? Status { get; set; }

    public string? Activitystatus { get; set; }

    public DateTime? Laststatusdate { get; set; }

    public bool? Inhandoff { get; set; }

    public DateTime? Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime? Editdate { get; set; }

    public string? Edituser { get; set; }

    public int Totalloads { get; set; }
}
