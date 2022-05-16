using DeckLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckLab.Controllers
{
    public class HomeController : Controller
    {
        public DeckAI dal = new DeckAI();
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Deck cards = dal.CallAPI("ztnd3y2kis02", "draw");
            return View(cards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}