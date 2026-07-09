using FluentValidation;
using SMConsulting.BL.DTOs.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Member
{
    public class MemberUpdateDtoValidator : AbstractValidator<MemberUpdateDto>
    {
        public MemberUpdateDtoValidator()
        {
            RuleFor(x => x.MemberFullName)
                .NotEmpty()
                .WithMessage("Full name is required.");

            RuleFor(x => x.MemberPosition)
                .NotEmpty()
                .WithMessage("Position is required.");

            RuleFor(x => x.MemberPhone)
                .NotEmpty()
                .WithMessage("Phone is required.");

            RuleFor(x => x.MemberDescription)
                .NotEmpty()
                .WithMessage("Description is required.");

            RuleFor(x => x.MemberEmail)
                .EmailAddress()
                .When(x => !string.IsNullOrWhiteSpace(x.MemberEmail))
                .WithMessage("Invalid email format.");
        }
    }
}
