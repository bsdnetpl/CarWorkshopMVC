namespace CarWarkshop.Application {
    public interface ICarWporkshopServices {
        Task Create(CarWorkshop.Domain.Entities.CarWorkshop carWorkshop);
    }
}