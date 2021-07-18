using AutoMapper;
using Commerce.Application;
using Commerce.Application.Core;
using Commerce.Application.Mapper;
using Commerce.BLL;
using Commerce.BLL.Core;
using Commerce.CrossCutting.Core.Interface;
using Commerce.CrossCutting.CurrentUser;
using Commerce.CrossCutting.Notification;
using Commerce.CrossCutting.Token;
using Commerce.Data.Core.DbContexts;
using Commerce.Data.DbContexts;
using Commerce.Data.UnitOfWork;
using Commerce.Domain.Interfaces;
using Commerce.Repository;
using Commerce.Repository.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Commerce.IoC
{
    public static class AppContainerInjection
    {
        public static IServiceCollection InjectDependencies(this IServiceCollection services)
        {
            services.InjectRepository();
            services.InjectBLL();
            services.InjectServices();
            services.InjectProfiles();
            services.InjectApp();

            return services;
        }

        private static IServiceCollection InjectApp(this IServiceCollection services)
        {
            services.AddScoped<IProductApp, ProductApp>();
            services.AddScoped<IUserApp, UserApp>();
            services.AddScoped<ILoginApp, LoginApp>();
            return services;
        }

        private static IServiceCollection InjectBLL(this IServiceCollection services)
        {
            services.AddScoped<IProductBLL, ProductBLL>();
            services.AddScoped<IUserBLL, UserBLL>();
            services.AddScoped<ILoginBLL, LoginBLL>();
            return services;
        }

        private static IServiceCollection InjectRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

        private static IServiceCollection InjectServices(this IServiceCollection services)
        {
            services.AddDbContext<IAppDbContext, AppDbContext>(o => o.UseLazyLoadingProxies());
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IServiceToken, ServiceToken>();
            services.AddScoped<IServiceNotification, ServiceNotification>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICurrentUser, CurrentUser>();
            return services;
        }

        private static IServiceCollection InjectProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var mappingConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductMappingProfile>();
                cfg.AddProfile<TokenMappingProfile>();
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
