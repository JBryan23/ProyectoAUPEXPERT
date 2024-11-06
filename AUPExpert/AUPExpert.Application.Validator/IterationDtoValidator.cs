using AUPExpert.Application.DTO;
using FluentValidation;

namespace AUPExpert.Application.Validator
{
    public sealed class IterationDtoValidator: AbstractValidator<IterationDto>
    {
        public IterationDtoValidator() 
        {
            RuleFor(p => p.Id).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(p => p.Phase).NotEmpty().NotNull().IsInEnum();
            RuleFor(p => p.State).NotEmpty().NotNull().IsInEnum();
            RuleFor(p => p.Objective).NotEmpty().NotNull();
            RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(p => p.StartDate).NotEmpty().NotNull();
            RuleFor(p => p.EndDate).NotEmpty().NotNull().GreaterThan(p => p.StartDate);

            RuleFor(p => p.ProjectId).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
