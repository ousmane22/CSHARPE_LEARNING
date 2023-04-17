using Microsoft.AspNetCore.Mvc;
using NdiayeShop.Models;
using NdiayeShop.ViewModels;

namespace NdiayeShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
           /* ViewBag.CurrentCategory = "Chesssss";
            return View(_pieRepository.AllPies);*/
           PieListViewModel pieListViewModel = new PieListViewModel(
              _pieRepository.AllPies  , "chesse cake"
           );

         return View(pieListViewModel);
        }


        public IActionResult Detail(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            else
                return View(pie);
        }
    }
}
