using AUPExpert.Application.DTO;
using AUPExpert.Application.DTO.Enums;
using FluentValidation;

namespace AUPExpert.Application.Validator
{
    public sealed class ProjectDtoValidator: AbstractValidator<ProjectDto>
    {
        public ProjectDtoValidator() 
        { 
            RuleFor(p => p.Id).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(p => p.Name).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(p => p.Description).NotNull().NotEmpty();
            RuleFor(p => p.StartDate).NotNull().NotEmpty();
            RuleFor(p => p.EndDate).NotNull().NotEmpty().GreaterThan(p => p.StartDate);
            RuleFor(p => p.State).NotNull().NotEmpty().IsInEnum();
            RuleFor(p => p).Custom((project, context) =>
            {
                if (project.State.Equals(ProjectStateDto.FINALIZADO))
                {

                    if (project.InitialPhaseCompleted.Equals(false) ||
                        project.ElaborationPhaseCompleted.Equals(false) ||
                        project.ConstructionPhaseCompleted.Equals(false) ||
                        project.TransitionPhaseCompleted.Equals(false))
                    {
                        context.AddFailure("Es requerido completar las cuatro fases de la metodología previamente, para marcar el proyecto como FINALIZADO.");
                    }
                }
            });

            RuleFor(p => p.InitialPhaseCompleted).NotNull();
            RuleFor(p => p.ElaborationPhaseCompleted).NotNull();
            RuleFor(p => p.ConstructionPhaseCompleted).NotNull();
            RuleFor(p => p.TransitionPhaseCompleted).NotNull();
        }

    }
}
