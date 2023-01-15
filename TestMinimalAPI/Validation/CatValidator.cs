using FluentValidation;
using TestMinimalAPI.Models;

namespace TestMinimalAPI.Validation
{
    public class CatValidator : AbstractValidator<Cat>
    {
        public CatValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Sex).NotNull();
            RuleFor(x => x.Age).NotNull().GreaterThan(0);
            RuleFor(x => x.Breed).NotNull();
        }
    }
}
