using CarWorkshop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWarkshop.Application 
{
    public class CarWporkshopServices : ICarWporkshopServices {
        private readonly ICarWorkshopRepoitory _carWorkshop;

        public CarWporkshopServices(ICarWorkshopRepoitory carWorkshop) {
            _carWorkshop = carWorkshop;
        }
        public async Task Create(CarWorkshop.Domain.Entities.CarWorkshop carWorkshop) {
            carWorkshop.EncodeName();
            await _carWorkshop.Create(carWorkshop);
        }
    }
}
