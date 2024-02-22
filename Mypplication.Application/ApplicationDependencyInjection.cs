using Microsoft.Extensions.DependencyInjection;
using MyApplication.Domain.Entities.Models;
using Mypplication.Application.Services.CarServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypplication.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            return services;
        }
    }
}
