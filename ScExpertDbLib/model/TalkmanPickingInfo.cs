using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class TalkmanPickingInfo
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Picklist { get; set; }

    public string? Picktype { get; set; }

    public string? Hutype { get; set; }

    public string? Warehousearea { get; set; }

    public string? DeliveryLocation { get; set; }

    public string DeliveryLocationCheckDigits { get; set; } = null!;

    public int? Printpicklabels { get; set; }

    public int? Printshiplabels { get; set; }

    public int? Printcontentlist { get; set; }

    public int AllowReprint { get; set; }

    public decimal? GoalTime { get; set; }

    public int AllowGoBack { get; set; }

    public double? TotalCube { get; set; }

    public double? TotalWeight { get; set; }

    public int TotalContainers { get; set; }
}
