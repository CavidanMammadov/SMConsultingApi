using FluentValidation;
using SMConsulting.BL.DTOs.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Hero
{
    public class HeroCreateDtoValidator : AbstractValidator<HeroCreateDto>
    {
        public HeroCreateDtoValidator()
        {
            RuleFor(x => x.HeroTitle)
                .NotEmpty()
                .WithMessage("Başlıq boş ola bilməz.");

            RuleFor(x => x.HeroDescription)
                .NotEmpty()
                .WithMessage("Təsvir boş ola bilməz.");

            RuleFor(x => x.HeroImage)
                .NotNull()
                .WithMessage("Şəkil seçilməlidir.");
        }
    }
}
