using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicledriver
{
    public string Driverid { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Fullname { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Driverlicensenumber { get; set; }

    public DateTime? Licenseissuedate { get; set; }

    public DateTime? Licensevalidthrudate { get; set; }

    public DateTime? Employmentstartdate { get; set; }

    public string? Socialsecuritynumber { get; set; }

    public string? Drivercontactid { get; set; }

    public string? Drivergroup { get; set; }

    public string? Territoryid { get; set; }

    public string? Comments { get; set; }

    public string Objecttype { get; set; } = null!;

    public bool? Active { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
