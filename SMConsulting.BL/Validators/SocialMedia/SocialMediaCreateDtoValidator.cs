using FluentValidation;
using SMConsulting.BL.DTOs.SocialMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.SocialMedia
{
    public class SocialMediaCreateDtoValidator :AbstractValidator<SocialMediaCreateDto>
    {
        public SocialMediaCreateDtoValidator()
        {
            RuleFor(x => x.SocialMediaFacebookUrl)
           .NotEmpty()
           .WithMessage("Facebook URL boş ola bilməz.")
           .MaximumLength(1024)
           .WithMessage("Facebook URL maksimum 1024 simvol ola bilər.");


            RuleFor(x => x.SocialMediaInstagramUrl)
                .NotEmpty()
                .WithMessage("Instagram URL boş ola bilməz.")
                .MaximumLength(1024)
                .WithMessage("Instagram URL maksimum 1024 simvol ola bilər.");


            RuleFor(x => x.SocialMediaLinekdinUrl)
                .NotEmpty()
                .WithMessage("LinkedIn URL boş ola bilməz.")
                .MaximumLength(1024)
                .WithMessage("LinkedIn URL maksimum 1024 simvol ola bilər.");


            RuleFor(x => x.SocialMediaYoutubeUrl)
                .NotEmpty()
                .WithMessage("YouTube URL boş ola bilməz.")
                .MaximumLength(1024)
                .WithMessage("YouTube URL maksimum 1024 simvol ola bilər.");
                
        }
    }
}
