using AUPExpert.Domain.Common;
using AUPExpert.Domain.Enums;

namespace AUPExpert.Domain.Entities;
public class Project: BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ProjectState State { get; set; } = ProjectState.PENDIENTE;
    public bool InitialPhaseCompleted { get; set; }
    public bool ElaborationPhaseCompleted { get; set; }
    public bool ConstructionPhaseCompleted { get; set; }
    public bool TransitionPhaseCompleted { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
