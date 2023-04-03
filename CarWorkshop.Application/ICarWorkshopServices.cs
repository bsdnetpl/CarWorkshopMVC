namespace CarWorkshop.Application {
    public interface ICarWorkshopServices {
        Task Create(Domain.Entities.CarWorkshop carWorkshop);
    }
}