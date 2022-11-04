using ClientDirectory.Application.Client.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Client.Validators
{
    public class BaseClientCommandValidator : AbstractValidator<BaseClientCommand>
    {
        public BaseClientCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty()
            .WithMessage("The field Name is necessary");
            RuleFor(c => c.LastName).NotEmpty()
            .WithMessage("The field LastName is necessary");
            RuleFor(x => x.BirthDate).NotEmpty().LessThan(DateTime.Now)
            .WithMessage("The field BirthDate is necessary, and should be younger than today");
            RuleFor(x => x.Dni).Length(11).Custom((x, context) =>
            {
                if (long.TryParse(x, out long value) is false)
                {
                    context.AddFailure($"{x} is not a valid number");
                }
            });
        }
    }
}
