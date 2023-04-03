namespace CarWarkshop.Application {
    public interface ICarWorkshopServices {
        Task Create(CarWorkshop.Domain.Entities.CarWorkshop carWorkshop);
    }
}