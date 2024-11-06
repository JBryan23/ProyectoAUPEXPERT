using AUPExpert.Application.DTO.Enums;

namespace AUPExpert.Application.DTO
{
    public sealed record IterationDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = "I-";
        public PhaseDto Phase { get; set; }

        public string Objective { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public IterationStateDto State { get; set; } = IterationStateDto.PENDIENTE;
        public int ProjectId { get; set; }
    }
}
