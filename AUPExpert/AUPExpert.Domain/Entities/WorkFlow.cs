using AUPExpert.Domain.Common;

namespace AUPExpert.Domain.Entities;

public class WorkFlow: BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int ProjectId { get; set; }
    public Project Project { get; set; }
}
