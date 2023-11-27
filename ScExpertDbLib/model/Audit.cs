using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Audit
{
    public string Auditid { get; set; } = null!;

    public string? Userid { get; set; }

    public DateTime? Activitydate { get; set; }

    public string? Activitytype { get; set; }

    public string? Document { get; set; }

    public int? Documentline { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Routeid { get; set; }

    public int? Stopnumber { get; set; }

    public int? Stoptaskid { get; set; }

    public string? Packageid { get; set; }

    public string? Fromload { get; set; }

    public string? Toload { get; set; }

    public string? Fromstatus { get; set; }

    public string? Tostatus { get; set; }

    public string? Fromloc { get; set; }

    public string? Toloc { get; set; }

    public decimal? Fromqty { get; set; }

    public decimal? Toqty { get; set; }

    public int? Activitytime { get; set; }

    public string? Mheid { get; set; }

    public string? Terminaltype { get; set; }

    public string? Fromcontainer { get; set; }

    public string? Tocontainer { get; set; }

    public string? Yardequipmentid { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public string? Driver1 { get; set; }

    public string? Driver2 { get; set; }

    public string? Carrier { get; set; }

    public string? Door { get; set; }

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
