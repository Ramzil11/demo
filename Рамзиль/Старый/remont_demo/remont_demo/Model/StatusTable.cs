﻿using System;
using System.Collections.Generic;

namespace remont_demo.Model;

public partial class StatusTable
{
    public int IdStatus { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<RequestsTable> RequestsTables { get; set; } = new List<RequestsTable>();
}
