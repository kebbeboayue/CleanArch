using CleanArch.Application.Automapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Configurations
{
    public static class AutomapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.Automapper.AutomapperConfiguration));
            AutomapperConfiguration.RegisterMappings();
        }
    }
}
