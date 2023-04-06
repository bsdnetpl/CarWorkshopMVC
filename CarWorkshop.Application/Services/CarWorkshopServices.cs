using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.Services
{
    public class CarWorkshopServices : ICarWorkshopServices
    {
        private readonly ICarWorkshopRepoitory _carWorkshop;
        private readonly IMapper _mapper;

        public CarWorkshopServices(ICarWorkshopRepoitory carWorkshop, IMapper mapper)
        {
            _carWorkshop = carWorkshop;
            _mapper = mapper;
        }
        public async Task Create(CarWorkshopDto carWorkshopDto)
        {
            var carWorkshop = _mapper.Map<Domain.Entities.CarWorkshop>(carWorkshopDto);
            carWorkshop.EncodeName();
            await _carWorkshop.Create(carWorkshop);
        }

        public async Task<IEnumerable<CarWorkshopDto>> GetAll()
        {
            var CarWorkshop = await _carWorkshop.GetAll();
            var dtos = _mapper.Map<IEnumerable<CarWorkshopDto>>(CarWorkshop);
            return dtos;

        }
    }
}
