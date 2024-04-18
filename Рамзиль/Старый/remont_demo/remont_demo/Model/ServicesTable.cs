using System;
using System.Collections.Generic;

namespace remont_demo.Model;

public partial class ServicesTable
{
    public int IdServices { get; set; }

    public int ServicesRequestId { get; set; }

    public string ServicesName { get; set; } = null!;

    public decimal ServicesCost { get; set; }

    public int ServicesCount { get; set; }

    public DateTime ServicesDate { get; set; }

    public virtual RequestsTable ServicesRequest { get; set; } = null!;
}
