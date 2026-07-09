using FluentValidation;
using SMConsulting.BL.DTOs.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Card
{
    public class CardUpdateDtoValidator :AbstractValidator<CardUpdateDto>
    {
        public CardUpdateDtoValidator()
        {
            RuleFor(x => x.CardDescription)
                .NotEmpty()
                .WithMessage("Description bos ola bilmez");
        }
    }
}
