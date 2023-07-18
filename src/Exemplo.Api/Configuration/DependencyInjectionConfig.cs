using Exemplo.Api.Extensions;
using Exemplo.Business.Interfaces;
using Exemplo.Business.Services;
using Exemplo.Data.Context;
using Exemplo.Business.ErrorNotifications;
using Exemplo.Business.Interfaces.Emails;
using LinkSys.Business.Services;
using Exemplo.Data.Repository;

namespace Exemplo.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ExemploDbContext>();
            services.AddScoped<IUser, AspNetUser>();

            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(uri);
            });

            services.AddScoped<IErrorNotifier, ErrorNotifier>();

            services.AddScoped<IEmailService, EmailService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
