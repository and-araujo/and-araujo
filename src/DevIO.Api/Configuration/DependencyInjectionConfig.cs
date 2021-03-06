﻿using DevIO.Api.Extensions;
using DevIO.Business.Intefaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DevIO.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<ISaborRepository, SaborRepository>();
            services.AddScoped<ITamanhoRepository, TamanhoRepository>();
            services.AddScoped<IAdicionalRepository, AdicionalRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<ISaborService, SaborService>();
            services.AddScoped<ITamanhoService, TamanhoService>();
            services.AddScoped<IAdicionalService, AdicionalService>();
            services.AddScoped<IPedidoService, PedidoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}