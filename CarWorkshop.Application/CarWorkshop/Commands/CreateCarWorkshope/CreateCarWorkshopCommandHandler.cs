using AutoMapper;
using CarWorkshop.Domain.Entities;
using CarWorkshop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshope
{
    public class CreateCarWorkshopCommandHandler : IRequestHandler<CreateCarWorkshopCommand>
    {
        private readonly ICarWorkshopRepoitory _carWorkshopRepoitory;
        private readonly IMapper _mapper;

        public CreateCarWorkshopCommandHandler(ICarWorkshopRepoitory carWorkshopRepoitory, IMapper mapper)
        {
            _carWorkshopRepoitory = carWorkshopRepoitory;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateCarWorkshopCommand request, CancellationToken cancellationToken)
        {
            
                var carWorkshop = _mapper.Map<Domain.Entities.CarWorkshop>(request);
                carWorkshop.EncodeName();
                await _carWorkshopRepoitory.Create(carWorkshop);
                return Unit.Value;
         }

    }
}
