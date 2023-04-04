using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
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
        public async  Task<IActionResult> Create(CarWorkshopDto carWorkshopDto) 
        {
           await _carWporkshopServices.Create(carWorkshopDto);
            return RedirectToAction(nameof(Create)); // todo refactor
        }
    }
}
