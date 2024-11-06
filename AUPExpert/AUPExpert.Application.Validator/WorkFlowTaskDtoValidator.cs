using AUPExpert.Application.DTO;
using FluentValidation;

namespace AUPExpert.Application.Validator
{
    public sealed class WorkFlowTaskDtoValidator: AbstractValidator<WorkFlowTaskDto>
    {
        public WorkFlowTaskDtoValidator()
        {
            RuleFor(p=>p.Id).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(p => p.Name).NotNull().NotEmpty().MaximumLength(75);
            RuleFor(p => p.Description).NotNull().NotEmpty();
            RuleFor(p => p.Priority).NotNull().NotEmpty().IsInEnum();
            RuleFor(p => p.State).NotNull().NotEmpty().IsInEnum();
            RuleFor(p => p.IterationId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(p => p.WorkFlowId).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
