using System;
using System.Collections.Generic;

namespace technoServise.Model;

public partial class RolesTable
{
    public int IdRole { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<StaffsTable> StaffsTables { get; set; } = new List<StaffsTable>();
}
