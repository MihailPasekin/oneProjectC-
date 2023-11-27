using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Laboruserinformation
{
    public string Employeeid { get; set; } = null!;

    public string Employeename { get; set; } = null!;

    public string Shift { get; set; } = null!;

    public DateTime Employeestartdate { get; set; }

    public string Employeestatus { get; set; } = null!;

    public string? Socialsecuritynumber { get; set; }

    public string? Phonenumber { get; set; }

    public string? Address { get; set; }
}
