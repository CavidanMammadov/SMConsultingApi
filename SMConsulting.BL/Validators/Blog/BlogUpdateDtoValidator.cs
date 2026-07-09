using FluentValidation;
using SMConsulting.BL.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Validators.Blog
{
    public class BlogUpdateDtoValidator : AbstractValidator<BlogUpdateDto>
    {
        public BlogUpdateDtoValidator()
        {
            RuleFor(x => x.BlogTitle)
            .NotEmpty()
            .WithMessage("Title is required.");

            RuleFor(x => x.BlogMainContent)
                .NotEmpty()
                .WithMessage("Main content is required.");

            RuleFor(x => x.BlogSubcontent)
                .NotEmpty()
                .WithMessage("Sub content is required.");

            RuleFor(x => x.BlogTags)
                .NotEmpty()
                .WithMessage("Tags are required.");
        }
    }
}
