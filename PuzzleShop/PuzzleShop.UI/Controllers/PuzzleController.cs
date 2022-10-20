using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PuzzleShop.Repos;
using PuzzleShop.Repos.Dto;

namespace PuzzleShop.UI.Controllers
{
    public class PuzzleController : Controller
    {
        private readonly PuzzleRepository _puzzleRepository;
        private readonly BrandRepository _brandRepository;
        private readonly CountryRepository _countryRepository;

        public PuzzleController(PuzzleRepository puzzleRepository, BrandRepository brandRepository, CountryRepository countryRepository)
        {
            _puzzleRepository = puzzleRepository;
            _brandRepository = brandRepository;
            _countryRepository = countryRepository;
        }

        public IActionResult Index()
        {
            var puzzles = _puzzleRepository.GetList();
            return View(puzzles);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Brands = _brandRepository.GetList();
            ViewBag.Countries = _countryRepository.GetList();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(PuzzleDto puzzleDto, string brands, string countries)
        {
            ViewBag.Brands = _brandRepository.GetList();
            ViewBag.Countries = _countryRepository.GetList();
            if (ModelState.IsValid)
            {
                var puzzle = await _puzzleRepository.CreatePuzzleFromDto(puzzleDto, brands, countries);
                return RedirectToAction("Edit","Puzzle", new { id = puzzle.Id });
            }
            return View(puzzleDto);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Brands = _brandRepository.GetList();
            ViewBag.Countries = _countryRepository.GetList();
            return View(_puzzleRepository.CreateDtoFromPuzzle(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(PuzzleDto puzzleDto, string brands, string countries)
        {
            ViewBag.Brands = _brandRepository.GetList();
            ViewBag.Countries = _countryRepository.GetList();
            if(ModelState.IsValid)
            {
                await _puzzleRepository.UpdatePuzzleAsync(puzzleDto, brands, countries);
                return RedirectToAction("Index");
            }
            return View(puzzleDto);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_puzzleRepository.CreateDtoFromPuzzle(id));
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _puzzleRepository.DeletePuzzleAsync(id);
            return RedirectToAction("Index");
        }
    }
}
