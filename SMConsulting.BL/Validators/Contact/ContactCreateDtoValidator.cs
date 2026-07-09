using FluentValidation;
using SMConsulting.BL.DTOs.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Contact
{
    public class ContactCreateDtoValidator : AbstractValidator<ContactCreateDto>
    {
        public ContactCreateDtoValidator()
        {
            RuleFor(x => x.ContactAdress)
          .NotEmpty()
          .WithMessage("Ünvan boş ola bilməz.");

            RuleFor(x => x.ContactEmail)
                .NotEmpty()
                .WithMessage("Email boş ola bilməz.")
                .EmailAddress()
                .WithMessage("Email formatı düzgün deyil.")
                .MaximumLength(256)
                .WithMessage("Email maksimum 256 simvol ola bilər.");


            RuleFor(x => x.ContactPhone)
                .NotEmpty()
                .WithMessage("Telefon nömrəsi boş ola bilməz.")
                .MaximumLength(32)
                .WithMessage("Telefon nömrəsi maksimum 32 simvol ola bilər.")
                .Matches(@"^\+?[0-9\s\-\(\)]+$")
                .WithMessage("Telefon nömrəsi düzgün formatda deyil.");
        }
    }
}
