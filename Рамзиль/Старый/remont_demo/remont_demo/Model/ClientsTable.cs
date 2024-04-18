using System;
using System.Collections.Generic;

namespace remont_demo.Model;

public partial class ClientsTable
{
    public int IdClient { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientSurname { get; set; }

    public string? ClientPhone { get; set; }

    public virtual ICollection<RequestsTable> RequestsTables { get; set; } = new List<RequestsTable>();
}
