using FluentValidation;

namespace SimpleMathOperationsAPI.DTO.Validators
{
    public class MathOperationRequestValidator : AbstractValidator<MathOperationRequest>
    {
        public MathOperationRequestValidator()
        {
            RuleFor(x => x.Num1).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Num2).GreaterThanOrEqualTo(0);
        }
    }
}
