using FluentValidation;
using SMConsulting.BL.DTOs.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Partner
{
    public class PartnerUpdateDtoValidator :AbstractValidator<PartnerUpdateDto>
    {
        public PartnerUpdateDtoValidator()
        {
            RuleFor(x => x.PartnerName)
           .NotEmpty()
           .WithMessage("Partner name is required.");

            RuleFor(x => x.PartnerDescription)
                .NotEmpty()
                .WithMessage("Partner description is required.");
        }
    }
}
