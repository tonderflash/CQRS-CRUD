using ClientDirectory.Application.Client.Queries;
using FluentValidation;

namespace ClientDirectory.Application.Client.Validators
{
    public class GetClientQueryValidator : AbstractValidator<GetClientQuery>
    {
        public GetClientQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty()
                .WithMessage("The field Id is necessary");
        }
    }
}
