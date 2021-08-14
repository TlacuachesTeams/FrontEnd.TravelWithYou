using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult Error404()
        {
            return View();
        }

        [Route("Error/500")]
        public IActionResult Error500()
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionFeature != null) {
                ViewBag.ErrorMessage = exceptionFeature.Error.Message;
                ViewBag.RouteOfException = exceptionFeature.Path;
            }
            return View();
        }

        [Route("Error")]
        public IActionResult Error()
        {
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionFeature != null)
            {
                ViewBag.ErrorMessage = exceptionFeature.Error.Message;
                ViewBag.RouteOfException = exceptionFeature.Path;
            }
            return View();
        }

    }
}
