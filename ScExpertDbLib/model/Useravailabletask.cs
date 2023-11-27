using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Useravailabletask
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Picklist { get; set; }

    public string? Parallelpicklist { get; set; }

    public string? Replenishment { get; set; }

    public string? Consolidation { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Fromlocation { get; set; }

    public string? Fromload { get; set; }

    public string? Fromcontainer { get; set; }

    public string? Tolocation { get; set; }

    public string? Toload { get; set; }

    public string? Tocontainer { get; set; }

    public int Priority { get; set; }

    public bool Assigned { get; set; }

    public string? Userid { get; set; }

    public string? Document { get; set; }

    public int? Documentline { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Assignedtime { get; set; }

    public int? Executiontime { get; set; }

    public string? Startlocation { get; set; }

    public string? Assignmenttype { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Creationdate { get; set; }

    public int Distance { get; set; }

    public int Z { get; set; }

    public int Y { get; set; }

    public int X { get; set; }

    public string Locmhtype { get; set; } = null!;

    public string Username { get; set; } = null!;

    public int Score { get; set; }
}
