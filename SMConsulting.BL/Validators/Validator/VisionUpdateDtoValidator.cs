using FluentValidation;
using SMConsulting.BL.DTOs.Vision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Validator
{
    public class VisionUpdateDtoValidator :AbstractValidator<VisionUpdateDto>
    {
        public VisionUpdateDtoValidator()
        {

            RuleFor(x => x.VisionSubDescription)
                .NotEmpty()
                .WithMessage("SubDescription bos ola bilmez");
            RuleFor(x => x.VisionDescription)
                .NotEmpty()
                .WithMessage("Description bos ola bilmez");
        }
    }
}
