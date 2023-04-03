using CarWarkshop.Application;
using CarWorkshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers {
    public class CarWorkshopController : Controller 
    {
        private readonly ICarWorkshopServices _carWporkshopServices;

        public CarWorkshopController( ICarWorkshopServices carWporkshopServices)
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
