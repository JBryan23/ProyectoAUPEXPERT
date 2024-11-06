using AUPExpert.Application.DTO.Enums;

namespace AUPExpert.Application.DTO
{
    public sealed record ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStateDto State { get; set; } = ProjectStateDto.PENDIENTE;
        public bool InitialPhaseCompleted { get; set; }
        public bool ElaborationPhaseCompleted { get; set; }
        public bool ConstructionPhaseCompleted { get; set; }
        public bool TransitionPhaseCompleted { get; set; }
    }
}
