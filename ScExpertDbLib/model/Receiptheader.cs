using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Receiptheader
{
    public string Receipt { get; set; } = null!;

    public string? Status { get; set; }

    public string? Bol { get; set; }

    public string? Notes { get; set; }

    public string? Carriercompany { get; set; }

    public DateTime? Startreceiptdate { get; set; }

    public DateTime? Closereceiptdate { get; set; }

    public string? Trailer { get; set; }

    public string? Vehicle { get; set; }

    public string? Driver1 { get; set; }

    public string? Driver2 { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public decimal? Estunloadingtime { get; set; }

    public string? Yardappointmentid { get; set; }

    public string? Transportreference { get; set; }

    public string? Transporttype { get; set; }

    public string? Door { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
