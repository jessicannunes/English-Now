using Microsoft.AspNetCore.Mvc;

namespace EnglishNow.Web.Controllers
{
    
    public class UsusarioController : Controller
    {
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
