using Microsoft.AspNetCore.Mvc;
using NdiayeShop.Models;
using NdiayeShop.ViewModels;

namespace NdiayeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository) 
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var PiesOfTheWeek = _pieRepository.PiesOfTheWeeks;
            var homeViewModel = new HomeViewModel(PiesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
