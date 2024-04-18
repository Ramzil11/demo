using System;
using System.Collections.Generic;

namespace remont_demo.Model;

public partial class TypeFaultTable
{
    public int IdTypeFault { get; set; }

    public string TypeFaultName { get; set; } = null!;

    public virtual ICollection<RequestsTable> RequestsTables { get; set; } = new List<RequestsTable>();
}
