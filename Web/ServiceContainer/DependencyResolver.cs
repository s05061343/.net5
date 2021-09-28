using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using Schedule;
using Service.Auth;
using Service.Auth.Token;
using Web.Filters;
using Web.Vaildations.Auth;

namespace Web.ServiceContainer
{
    public static class DependencyResolver
    {
        public static ServiceProvider Services { get; private set; }
        public static void InitComponents(IServiceCollection services)
        {
            DependencyResolver.InitDbContext(services);
            DependencyResolver.InitService(services);
            DependencyResolver.InitValidator(services);
            Services = services.BuildServiceProvider();
        }

        private static void InitDbContext(IServiceCollection services)
        {
            services.AddScoped<DbContext, Model.HeroKuPostgreSQL.TomzContext>();
        }

        private static void InitService(IServiceCollection services)
        {
            services.AddScoped<IAuthManager, AuthManager<JWT>>();
            services.AddScoped<JWT>();
            services.AddScoped<AuthorizationFilter>();
            services.AddScoped<ExceptionFilter>();

            //向DI容器註冊Quartz服務
            services.AddSingleton<IJobFactory, JobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            //向DI容器註冊Job
            services.AddSingleton<ReportJob>();
            //向DI容器註冊Host服務
            services.AddSingleton<QuartzHostedService>();
        }

        private static void InitValidator(IServiceCollection services)
        {
            services.AddScoped<IAuthRequestValidator, AuthRequestValidator>();
        }
    }
}
