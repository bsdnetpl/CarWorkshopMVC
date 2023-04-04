using CarWorkshop.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDtoValidator:AbstractValidator<CarWorkshopDto>
    {
        public CarWorkshopDtoValidator(ICarWorkshopRepoitory repoitory)
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(20)
                .Custom((value, context) => 
                {
                    var existing = repoitory.GetByName(value).Result;
                    if (existing != null) 
                    {
                      context.AddFailure($"{value} is not unique name  for car workshop");
                    }
                });
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.PhoneNumber).MinimumLength(8).MaximumLength(12);
        }
    }
}
