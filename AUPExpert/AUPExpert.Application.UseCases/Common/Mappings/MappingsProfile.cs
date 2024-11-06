using AUPExpert.Application.DTO;
using AUPExpert.Domain.Entities;
using AutoMapper;

namespace AUPExpert.Application.UseCases.Common.Mappings
{
    internal sealed class MappingsProfile: Profile
    {
        public MappingsProfile()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Iteration, IterationDto>().ReverseMap();
            CreateMap<WorkFlow, WorkFlowDto>().ReverseMap();
            CreateMap<WorkFlowTask, WorkFlowTaskDto>().ReverseMap();
        }
    }
}
