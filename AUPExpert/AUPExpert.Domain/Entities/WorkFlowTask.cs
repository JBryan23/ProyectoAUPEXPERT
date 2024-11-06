using AUPExpert.Domain.Common;
using AUPExpert.Domain.Enums;

namespace AUPExpert.Domain.Entities;

public class WorkFlowTask:BaseEntity
{    
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Priority Priority { get; set; } = Priority.BAJA;

    public WorkFlowTaskState State { get; set; } = WorkFlowTaskState.PENDIENTE;

    public int IterationId { get; set; }
    public Iteration Iteration { get; set; }

    public int WorkFlowId { get; set; }
    public WorkFlow WorkFlow { get; set; }
}
