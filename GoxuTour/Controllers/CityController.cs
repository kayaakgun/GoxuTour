using GoxuTour.Application.Cities;
using Microsoft.AspNetCore.Mvc;

namespace GoxuTour.Presentation.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public IActionResult Index()
        {
            var cities = _cityService.GetAll();
            return View(cities);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CityDTO city)
        {
            _cityService.Create(city);
            return RedirectToAction("Index");
        }
        public IActionResult GetById(int id)
        {
            var city = _cityService.GetById(id);
            return View(city);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var city = _cityService.GetById(id);
            return View(city);
        }

        [HttpPost]
        public IActionResult Update(CityDTO city)
        {
            if (city != null)
            {
                _cityService.Update(city);
                return RedirectToAction("Index");
            }

            return Content("Hatalı İşlem");
        }

        public IActionResult Delete(CityDTO cityDTO)
        {
            if(cityDTO != null)
            {
                var city = _cityService.GetById(cityDTO.Id);
                _cityService.Delete(city);

                return RedirectToAction("Index");
            }
            return Content("Silinecek kayıt bulunamadı");
        }
    }
}
