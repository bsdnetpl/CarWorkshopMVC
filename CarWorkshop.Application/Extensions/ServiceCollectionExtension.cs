﻿using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshope;
using CarWorkshop.Application.Mappings;

using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Extensions
{
    public static class ServiceCollectionExtension 
    {
        public static void AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(typeof(CreateCarWorkshopCommand));
            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
            services.AddValidatorsFromAssemblyContaining<CarWorkshopDtoCommandValidator>()
                .AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

        }

    }
}
