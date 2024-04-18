using System;
using System.Collections.Generic;

namespace technoServise.Model;

public partial class RequestsTable
{
    public int IdRequest { get; set; }

    public DateTime RequestCreateDate { get; set; }

    public DateTime? RequestFinishedDate { get; set; }

    public string ReuestEquipment { get; set; } = null!;

    public string RequestsDescription { get; set; } = null!;

    public int RequestTypeFaultId { get; set; }

    public int RequestClietnId { get; set; }

    public int? RequestStatusId { get; set; }

    public string? RequestPriority { get; set; }

    public string? RequestComment { get; set; }

    public virtual ICollection<PerformersTable> PerformersTables { get; set; } = new List<PerformersTable>();

    public virtual ClientsTable RequestClietn { get; set; } = null!;

    public virtual StatusTable? RequestStatus { get; set; }

    public virtual TypeFaultTable RequestTypeFault { get; set; } = null!;

    public virtual ICollection<ServicesTable> ServicesTables { get; set; } = new List<ServicesTable>();
}
