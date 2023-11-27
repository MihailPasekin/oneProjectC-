using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routestopdetail
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public int Stopdetailid { get; set; }

    public string Stopdetailtype { get; set; } = null!;

    public string? Stopdetailname { get; set; }

    public DateTime? Schedualeddate { get; set; }

    public string? Consignee { get; set; }

    public string? Documentid { get; set; }

    public string? Documenttype { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public string? Packtype { get; set; }

    public int? Numpacks { get; set; }

    public string? Transportationclass { get; set; }

    public decimal? Stopdetvolume { get; set; }

    public decimal? Stopdetweight { get; set; }

    public decimal? Stopdetvalue { get; set; }

    public string Status { get; set; } = null!;

    public string? Comments { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
