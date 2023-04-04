using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Mappings {
    public class CarWorkshopMappingProfile: Profile 
    {
        public CarWorkshopMappingProfile()
        {
            CreateMap<CarWorkshopDto, Domain.Entities.CarWorkshop>()
                .ForMember(d => d.ContactDetails, opt => opt.MapFrom(s => new CarWorkshopContactDetails()
                {
                    City = s.City,
                    PhoneNumber = s.PhoneNumber,
                    Postalcode = s.Postalcode,
                    Street = s.Street
                }));
        }
    }
}
