using AUPExpert.Application.DTO.Enums;

namespace AUPExpert.Application.DTO
{
    public sealed record class WorkFlowTaskDto
    {
        //[Key]
        //[Column("id", TypeName = "int(11)")]
        public int Id { get; set; }

        //[StringLength(75)]
        public string Name { get; set; } = string.Empty;

        //[Required]
        //[Column(TypeName = "text")]
        public string Description { get; set; } = string.Empty;

        //[Column(TypeName = "enum('Alta','Media','Baja')")]
        public PriorityDto Priority { get; set; } = PriorityDto.BAJA;

        public WorkFlowTaskStateDto State { get; set; } = WorkFlowTaskStateDto.PENDIENTE;

        //[Column("idIteracion", TypeName = "int(11)")]
        public int IterationId { get; set; }

        //[Column("idFlujoTrabajo", TypeName = "int(11)")]
        public int WorkFlowId { get; set; }
    }
}
