using CarWorkshop.Application.CarWorkshop;

namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopServices
    {
        Task Create(CarWorkshopDto carWorkshopDto);
        Task <IEnumerable<CarWorkshopDto>>GetAll();

    }
}