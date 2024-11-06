using AUPExpert.Application.DTO;
using FluentValidation;

namespace AUPExpert.Application.Validator
{
    public sealed class WorkFlowDtoValidator: AbstractValidator<WorkFlowDto>
    {
        public WorkFlowDtoValidator()
        {
            RuleFor(p => p.Id).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(p => p.Name).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(p => p.Description).NotNull().NotEmpty();
        }
    }
}
