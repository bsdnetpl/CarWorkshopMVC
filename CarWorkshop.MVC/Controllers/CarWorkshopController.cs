using CarWarkshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers {
    public class CarWorkshopController : Controller 
    {
        private readonly ICarWporkshopServices _carWporkshopServices;

        public CarWorkshopController( ICarWporkshopServices carWporkshopServices)
        {
            _carWporkshopServices = carWporkshopServices;
        }
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create(Domain.Entities.CarWorkshop carWorkshop) 
        {
           await _carWporkshopServices.Create(carWorkshop);
            return RedirectToAction(nameof(Create)); // todo refactor
        }
    }
}
