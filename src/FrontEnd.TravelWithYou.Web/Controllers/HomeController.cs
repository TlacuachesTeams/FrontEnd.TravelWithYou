using FrontEnd.TravelWithYou.Core.Destinations;
using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using FrontEnd.TravelWithYou.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
using FrontEnd.TravelWithYou.Utils;
using FrontEnd.TravelWithYou.Entities.Common.AboutUs;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IDestinationCore destinationCore;
        public HomeController(IDestinationCore destinationCore) : base()
        {
            this.destinationCore = destinationCore;
        }

        [Route("")]
        public async Task<IActionResult> Index()
        {           
            try
            {
                ViewBag.ReadFile = false;
                DestinationRS response = await destinationCore.GetDestinationsList();
                if (response != null) {
                    ViewBag.Metas = HelperMetas.GetMetas(response.Metas?.Metas,"home-principal");
                    ViewBag.ReadFile = response.ReadFile;
                }
                return View(response);
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = $"Critical exception: {ex.Message}, Trace: {ex.StackTrace}";
                return View("/Views/Error/Error.cshtml");
            }
        }

        [Route("hotels")]
        [Route("hoteles")]
        public IActionResult hotels()
        {
            return View();
        }

        [Route("activities")]
        [Route("tours")]        
        public IActionResult tours()
        {
            return View();
        }

        [Route("shuttles")]
        [Route("traslados")]
        public IActionResult shuttles()
        {
            return View();
        }

        [Route("cars")]
        [Route("autos")]
        public IActionResult cars()
        {
            return View();
        }

        [Route("flights")]
        [Route("vuelos")]
        public IActionResult flights()
        {
            return View();
        }

        [Route("packages")]
        [Route("paquetes")]
        public IActionResult packages()
        {
            return View();
        }

        [Route("deals")]
        [Route("ofertas")]
        public IActionResult deals()
        {
            return View();
        }
            
        [Route("privacidad")]
        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("aboutus")]
        [Route("acercadenosotros")]
        public async Task<IActionResult> AboutUs()
        {
            AboutUs response = destinationCore.GetDestinationsList().Result.AboutUs;
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
