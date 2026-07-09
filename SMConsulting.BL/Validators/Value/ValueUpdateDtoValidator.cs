using FluentValidation;
using SMConsulting.BL.DTOs.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Value
{
    public class ValueUpdateDtoValidator :AbstractValidator<ValueUpdateDto>
    {
        public ValueUpdateDtoValidator()
        {
            RuleFor(x => x.ValueTitle)
           .NotEmpty()
           .WithMessage("Başlıq boş ola bilməz.");

            RuleFor(x => x.ValueDescription)
                .NotEmpty()
                .WithMessage("ValueDescription boş ola bilməz.");

            RuleFor(x => x.ValueFooterTitle)
                .NotEmpty()
                .WithMessage("Footer başlıq boş ola bilməz.");

            RuleFor(x => x.ValueFooterDescription)
                .NotEmpty()
                .WithMessage("Footer açıqlama boş ola bilməz.");
        }
    }
}
