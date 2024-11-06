using AUPExpert.Domain.Common;
using AUPExpert.Domain.Enums;

namespace AUPExpert.Domain.Entities;

public class Iteration: BaseEntity
{
    public string Code { get; set; }
    public Phase Phase { get; set; }

    public string Objective { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public IterationState State { get; set; }

    public int ProjectId { get; set; }
    public Project? Project { get; set; }
}
