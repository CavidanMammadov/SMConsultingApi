using FluentValidation;
using SMConsulting.BL.DTOs.Applyment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Applyment
{
    public class ApplymentUpdateDtoValidator :AbstractValidator<ApplymentUpdateDto>
    {
        public ApplymentUpdateDtoValidator()
        {
           

            RuleFor(x => x.ApplymentName)
                .NotEmpty()
                .WithMessage("Ad boş ola bilməz.")
                .MaximumLength(128)
                .WithMessage("Ad maksimum 128 simvol ola bilər.");

            RuleFor(x => x.ApplymentEmail)
                .NotEmpty()
                .WithMessage("Email boş ola bilməz.")
                .EmailAddress()
                .WithMessage("Email formatı düzgün deyil.")
                .MaximumLength(256)
                .WithMessage("Email maksimum 256 simvol ola bilər.");

            RuleFor(x => x.ApplymentPhone)
                .NotEmpty()
                .WithMessage("Telefon nömrəsi boş ola bilməz.")
                .MaximumLength(32)
                .WithMessage("Telefon nömrəsi maksimum 32 simvol ola bilər.")
                .Matches(@"^\+?[0-9\s\-\(\)]+$")
                .WithMessage("Telefon nömrəsi düzgün formatda deyil.");

            RuleFor(x => x.ApplymentCompany)
                .MaximumLength(256)
                .WithMessage("Şirkət adı maksimum 256 simvol ola bilər.");

            RuleFor(x => x.ApplymentPosition)
                .MaximumLength(128)
                .WithMessage("Vəzifə adı maksimum 128 simvol ola bilər.");

            RuleFor(x => x.ApplymentMessage)
                .MaximumLength(2048)
                .WithMessage("Mesaj maksimum 2048 simvol ola bilər.");
        }
    }
}
