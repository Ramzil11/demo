using System;
using System.Collections.Generic;

namespace technoServise.Model;

public partial class PerformersTable
{
    public int StuffId { get; set; }

    public int RequestId { get; set; }

    public virtual RequestsTable Request { get; set; } = null!;

    public virtual StaffsTable Stuff { get; set; } = null!;
}
