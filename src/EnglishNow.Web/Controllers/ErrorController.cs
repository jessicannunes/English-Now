using EnglishNow.Web.Models.Error;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EnglishNow.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var expectionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();

            var model = new ErrorViewModel
            {
                MensagemErro = expectionHandlerFeature == null ? "Erro insperado" : expectionHandlerFeature.Error.Message
            };

            return View(model);
        }
    }
}