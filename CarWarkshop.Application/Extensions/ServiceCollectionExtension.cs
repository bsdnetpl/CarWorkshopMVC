﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWarkshop.Application.Extensions 
{
    public static class ServiceCollectionExtension 
    {
        public static void AddApplication(this IServiceCollection services) 
        {
            services.AddScoped<ICarWporkshopServices, CarWporkshopServices>();
        }

    }
}
