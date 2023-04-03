namespace CarWarkshop.Application {
    public interface ICarWorkshopServices {
        Task Create(CarWarkshop.Domain.Entities.CarWorkshop carWorkshop);
    }
}