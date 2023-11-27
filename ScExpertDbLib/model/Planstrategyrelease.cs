using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Planstrategyrelease
{
    public int Releasepolicyid { get; set; }

    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Picktype { get; set; }

    public bool? Printpicklist { get; set; }

    public bool Printcontentlist { get; set; }

    public string? Autoprintpicklabels { get; set; }

    public bool? Createjob { get; set; }

    public int? Jobpriority { get; set; }

    public string? Contentlistdocname { get; set; }

    public string? Confirmationtype { get; set; }

    public bool? Grouppickdetails { get; set; }

    public string? Autorelease { get; set; }

    public string? Labelformat { get; set; }

    public string? Systempickshort { get; set; }

    public string? Userpickshort { get; set; }

    public bool? Delcontonclose { get; set; }

    public string? Shiplabelformat { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
