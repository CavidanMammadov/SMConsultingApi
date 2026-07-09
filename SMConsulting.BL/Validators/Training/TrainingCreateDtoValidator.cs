using FluentValidation;
using SMConsulting.BL.DTOs.Training;

namespace SMConsulting.BL.Validators.Training
{
    public class TrainingCreateDtoValidator :AbstractValidator<TrainingCreateDto>
    {
        public TrainingCreateDtoValidator()
        {
            RuleFor(x => x.TrainingTitle)
                .NotEmpty().
                WithMessage("Title bos ola bilmez");
            RuleFor(x => x.TrainingDescription)
                .NotEmpty().
                WithMessage("Description bos ola bilmez");
        }
    }
}
