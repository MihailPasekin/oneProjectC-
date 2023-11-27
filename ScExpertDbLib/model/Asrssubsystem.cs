using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Asrssubsystem
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? Type { get; set; }

    public bool? Sendhuininductionlocation { get; set; }

    public bool? Waithudestinationrequest { get; set; }

    public bool? Sendmovehurequest { get; set; }

    public bool? Handlehumovestarted { get; set; }

    public bool? Handlehumovecompleted { get; set; }

    public bool? Sendtorejectlocation { get; set; }

    public bool? Completepickoperation { get; set; }

    public bool? Completeputawayoperation { get; set; }

    public bool? Completereplenishoperation { get; set; }

    public bool? Reverseputawaylocation { get; set; }

    public bool? Ignoreinductionlocation { get; set; }

    public bool? Putawayreplcont { get; set; }

    public bool? Findnewlocifrejected { get; set; }

    public bool? Sendpwreqonmovereq { get; set; }

    public bool? Createtaskwhileanotherexist { get; set; }

    public bool? Mixcontainertask { get; set; }

    public bool? Managebuffer { get; set; }

    public int? Buffersize { get; set; }

    public bool? Autosendnexttask { get; set; }

    public bool? Fixedlocation { get; set; }

    public bool? Manualputawaymode { get; set; }

    public bool? Firsttaskonhold { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
