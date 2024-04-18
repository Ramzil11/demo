using System;
using System.Collections.Generic;

namespace technoServise.Model;

public partial class StaffsTable
{
    public int IdStaff { get; set; }

    public string StaffName { get; set; } = null!;

    public string StaffSurname { get; set; } = null!;

    public string StaffPhone { get; set; } = null!;

    public string StaffPassword { get; set; } = null!;

    public int StaffRoleId { get; set; }

    public string StuffLogin { get; set; } = null!;

    public virtual PerformersTable? PerformersTable { get; set; }

    public virtual RolesTable StaffRole { get; set; } = null!;
}
