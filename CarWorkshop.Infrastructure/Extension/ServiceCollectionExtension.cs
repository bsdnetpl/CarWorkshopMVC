using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistance;
using CarWorkshop.Infrastructure.Repositories;
using CarWorkshop.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkshopDbContext>(opt => opt.UseSqlServer(
           configuration.GetConnectionString("CS")).LogTo(Console.Write));

            services.AddScoped<CarWorkshopSeeder>();
            services.AddScoped<ICarWorkshopRepoitory, CarWorkshopRepository>();
        }
    }
}
