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
        public async Task<IActionResult> Index()
        {
            var carWorkshop = await _carWporkshopServices.GetAll();
            return View(carWorkshop);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create(CarWorkshopDto carWorkshopDto) 
        {
            if(!ModelState.IsValid)
            {
                return View(carWorkshopDto);
            }
           await _carWporkshopServices.Create(carWorkshopDto);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
