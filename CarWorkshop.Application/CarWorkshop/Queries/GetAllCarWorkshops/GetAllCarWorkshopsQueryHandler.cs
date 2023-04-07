using AutoMapper;
using CarWorkshop.Domain.Entities;
using CarWorkshop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetAllCarWorkshops
{
    public class GetAllCarWorkshopsQueryHandler : IRequestHandler<GetAllCarWorkshopsQuery, IEnumerable<CarWorkshopDto>>
    {
        private readonly ICarWorkshopRepoitory _carWorkshopRepoitory;
        private readonly IMapper _mapper;

        public GetAllCarWorkshopsQueryHandler(ICarWorkshopRepoitory carWorkshopRepoitory, IMapper mapper)
        {
            _carWorkshopRepoitory = carWorkshopRepoitory;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarWorkshopDto>> Handle(GetAllCarWorkshopsQuery request, CancellationToken cancellationToken)
        {
            var CarWorkshop = await _carWorkshopRepoitory.GetAll();
            var dtos = _mapper.Map<IEnumerable<CarWorkshopDto>>(CarWorkshop);
            return dtos;
        }
    }
}
