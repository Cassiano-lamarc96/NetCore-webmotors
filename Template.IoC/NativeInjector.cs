using Microsoft.Extensions.DependencyInjection;
using System;
using Template.Application.Interfaces;
using Template.Application.Services;
using Template.Data.Repositories;
using Template.Domain.Interfaces;

namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IAnuncioService, AnuncioService>();
            
            #endregion

            #region Repositories
            
            services.AddScoped<IAnuncioRepository, AnuncioRepository>();
            
            #endregion
        }
    }
}
