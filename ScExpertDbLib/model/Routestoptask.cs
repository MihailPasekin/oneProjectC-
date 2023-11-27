using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routestoptask
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public int Stoptaskid { get; set; }

    public string Stoptasktype { get; set; } = null!;

    public string? Stoptaskname { get; set; }

    public DateTime? Schedualeddate { get; set; }

    public string? Consignee { get; set; }

    public string? Documentid { get; set; }

    public string? Documenttype { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public string? Contactid { get; set; }

    public string? Packtype { get; set; }

    public int? Numpacks { get; set; }

    public string? Transportationclass { get; set; }

    public decimal? Stopdetvolume { get; set; }

    public decimal? Stopdetweight { get; set; }

    public decimal? Stopdetvalue { get; set; }

    public string Status { get; set; } = null!;

    public string? Comments { get; set; }

    public string? Confirmationtype { get; set; }

    public string? Reasoncode { get; set; }

    public string? Confdocid { get; set; }

    public string? Confirmationnumber { get; set; }

    public string? Confirmationlevel { get; set; }

    public bool? Allowpartialloading { get; set; }

    public bool? Allowpartialunloading { get; set; }

    public bool? Confirmpackageatunloading { get; set; }

    public bool? Allowpartialpickup { get; set; }

    public string? Chkpnt { get; set; }

    public string? Recipient { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
