using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            CreateMap<Domain.Entities.CarWorkshop, CarWorkshopDto>()
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.ContactDetails.Street))
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.ContactDetails.City))
                .ForMember(dto => dto.Postalcode, opt => opt.MapFrom(src => src.ContactDetails.Postalcode))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.ContactDetails.PhoneNumber));

        }
    }
}
