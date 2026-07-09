using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.ExternalServices.Implements;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.BL.Services.Implements;

namespace SMConsulting.BL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddScoped<IApplymentService, ApplymentService>();
            services.AddScoped<IHeroService, HeroService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<ISocialMediaService, SocialMediaService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IVisionService, VisionService>();
            services.AddScoped<IValueService, ValueService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IPartnerService, PartnerService>();
            services.AddScoped<ISectorService, SectorService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<ICardSpecificationService, CardSpecificationService>();
            services.AddScoped<ITrainingService, TrainingService>();
            services.AddScoped<ISectorHelpService, SectorHelpService>();
            services.AddScoped<IDifficultyService, DifficultyService>();

            return services;
        }
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(typeof(ServiceRegistration).Assembly);
            return services;

        }
    }
}
