using FluentValidation;
using SMConsulting.BL.DTOs.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Team
{
    public class TeamCreateDtoValidator : AbstractValidator<TeamCreateDto>
    {
        public TeamCreateDtoValidator()
        {
            RuleFor(x => x.TeamTitle)
           .NotEmpty()
           .WithMessage("Team title is required.");

            RuleFor(x => x.TeamTitleHiglight)
                .NotEmpty()
                .WithMessage("Team title highlight is required.");

            RuleFor(x => x.TeamDescription)
                .NotEmpty()
                .WithMessage("Team description is required.");
        }
    }
}
