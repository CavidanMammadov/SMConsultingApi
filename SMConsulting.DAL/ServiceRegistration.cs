using Microsoft.Extensions.DependencyInjection;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Repositories;

namespace SMConsulting.DAL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddScoped< IApplymentRepository, ApplymentRepository >();
            services.AddScoped<IHeroRepository, HeroRepository>();
            services.AddScoped<IContacyRepository, ContactRepository>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IVisionRepository, VisionRepository>();
            services.AddScoped<IValueRepository, ValueRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IPartnerRepository, PartnerRepository >();
            services.AddScoped<ISectorRepository, SectorRepository >();
            services.AddScoped<IServiceRepository, ServiceRepository >();
            services.AddScoped<ICardSpecificationRepository, CardSpecificationRepository >();
            services.AddScoped<ITrainingRepository, TrainingRepository >();
            services.AddScoped<ISectorHelpRepository, SectorHelpRepository >();
            services.AddScoped<IDifficultyRepository, DifficultyRepository >();
            return services;
        }
    }
}
