using CarWorkshop.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshope
{
    public class CarWorkshopDtoCommandValidator : AbstractValidator<CreateCarWorkshopCommand>
    {
        public CarWorkshopDtoCommandValidator(ICarWorkshopRepoitory repoitory)
        {
            RuleFor(c => c.Name)
                    .NotEmpty()
                    .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
                    .MaximumLength(20).WithMessage("Name should have maxium of 20 characters")
                    .Custom((value, context) =>
                    {
                        var existingCarWorkshop = repoitory.GetByName(value).Result;
                        if (existingCarWorkshop != null)
                        {
                            context.AddFailure($"{value} is not unique name for car workshop");
                        }
                    });

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please enter description");

            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
