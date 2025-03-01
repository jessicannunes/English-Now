using System.Diagnostics;
using EnglishNow.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishNow.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            throw new Exception("Erro de exemplo");

            return View();
        }

    }
}
