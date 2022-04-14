using GoxuTour.Application.Cities;
using GoxuTour.Application.Stations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoxuTour.Presentation.Controllers
{
    public class StationController : Controller
    {
        private readonly IStationService _stationService;
        private readonly ICityService _cityService;

        public StationController(IStationService stationService,ICityService cityService)
        {
            _stationService = stationService;
            _cityService = cityService;

        }

        public IActionResult Index()
        {
            var stations = _stationService.GetAll();
            var citys = _cityService.GetAll();
            ViewBag.CityList = citys;
            return View(stations);
        }

        public IActionResult Create()
        {
            var cities = _cityService.GetAll();
            ViewBag.CityList = new SelectList(cities, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(StationDTO stationDTO)
        {
            _stationService.Create(stationDTO);
            return RedirectToAction("Index");
        }

        public IActionResult GetById(StationDTO stationDTO)
        {
            var station = _stationService.GetById(stationDTO.Id);
            return View(station);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var station = _stationService.GetById(id);
            var cities = _cityService.GetAll();
            ViewBag.CityList = new SelectList(cities, "Id", "Name");
            return View(station);
        }

        [HttpPost]
        public IActionResult Update(StationDTO stationDTO)
        {
            if(stationDTO != null)
            {
                _stationService.Update(stationDTO);
                return RedirectToAction("Index");
            }
            return Content("Hatalı İşlem");
        }

        public IActionResult Delete(StationDTO stationDTO)
        {
            if(stationDTO != null)
            {

                var station = _stationService.GetById(stationDTO.Id);
                _stationService.Delete(stationDTO);
                return RedirectToAction("Index");
            }

            return Content("Station Bulunamadı");
           
        }
    }
}
