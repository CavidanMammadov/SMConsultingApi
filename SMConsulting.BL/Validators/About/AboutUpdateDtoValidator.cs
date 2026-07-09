using FluentValidation;
using SMConsulting.BL.DTOs.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.About
{
    public class AboutUpdateDtoValidator :AbstractValidator<AboutUpdateDto>
    {
        public AboutUpdateDtoValidator()
        {
            RuleFor(x => x.AboutTitle).NotEmpty()
                .WithMessage("Title bos ola bilmez");
            RuleFor(x => x.AboutDescription).NotEmpty()
                .WithMessage("description bos ola bilmez");
        }
    }
}
