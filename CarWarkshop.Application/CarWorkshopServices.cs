using CarWorkshop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWarkshop.Application 
{
    public class CarWorkshopServices : ICarWorkshopServices {
        private readonly ICarWorkshopRepoitory _carWorkshop;

        public CarWorkshopServices(ICarWorkshopRepoitory carWorkshop) {
            _carWorkshop = carWorkshop;
        }
        public async Task Create(CarWorkshop.Domain.Entities.CarWorkshop carWorkshop) {
            carWorkshop.EncodeName();
            await _carWorkshop.Create(carWorkshop);
        }
    }
}
