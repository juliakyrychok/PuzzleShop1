using Microsoft.AspNetCore.Mvc;
using PuzzleShop.Core;
using PuzzleShop.Repos;

namespace PuzzleShop.UI.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryRepository _countryRepository;
        public CountryController(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IActionResult Index()
        {
            var countries = _countryRepository.GetList();
            return View(countries);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Country country)
        {
            if (ModelState.IsValid)
            {
                var createdCountry = await _countryRepository.CreateCountryAsync(country);
                return RedirectToAction("Edit", "Country", new { id = createdCountry.Id });
            }
            return View(country);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_countryRepository.GetCountryById(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                await _countryRepository.UpdateCountryAsync(country);
                return RedirectToAction("Index");
            }
            return View(country);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_countryRepository.GetCountryById(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(Country Country)
        {
            await _countryRepository.DeleteCountryAsync(Country.Id);
            return RedirectToAction("Index");
        }
    }
}
