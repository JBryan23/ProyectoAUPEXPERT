namespace AUPExpert.Application.DTO
{
    public sealed record WorkFlowDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
    }
}
