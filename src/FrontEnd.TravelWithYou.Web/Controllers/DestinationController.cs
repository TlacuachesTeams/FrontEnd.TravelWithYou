using FrontEnd.TravelWithYou.Core.Destinations;
using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using FrontEnd.TravelWithYou.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using System;
using System.Linq;
using FrontEnd.TravelWithYou.Utils;
using System.Collections.Generic;
using FrontEnd.TravelWithYou.Entities.Common;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class DestinationController : BaseController
    {        
        private readonly IDestinationCore destinationCore;
        public DestinationController(IDestinationCore destinationCore) : base()
        {
            this.destinationCore = destinationCore;
        }

        [Route("destinations")]
        [Route("destinos")]
        public async Task<IActionResult> destinations()
        {
            try
            {
                ViewBag.ReadFile = false;
                DestinationRS response = await destinationCore.GetDestinationsList();
                if (response != null)
                {
                    var firstCountry = response.Countries?.FirstOrDefault();                    
                    List<KeyValue> replaceKeys = new List<KeyValue> {
                        new KeyValue { Key = "{CountryName}", Value = firstCountry.CountryName }                       
                    };
                    ViewBag.Metas = HelperMetas.GetMetas(response.Metas?.Metas, "home-destinations", replaceKeys);
                    ViewBag.ReadFile = response.ReadFile;
                }
                //response.Countries.All(dt => dt.Destinations.OrderBy(dt => dt.DestinationName).ToList()).ToList();
                return View(response);
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = $"Critical exception: {ex.Message}, Trace: {ex.StackTrace}";
                return View("/Views/Error/Error.cshtml");
            }
        }

        [HttpGet]
        [Route("destinations/{orderId}/{orderType}")]
        [Route("destinos/{orderId}/{orderType}")]
        public async Task<IActionResult> destinations([FromRoute] int orderId, [FromRoute] string orderType)
        {
            return ViewComponent("Destinations", new { OrderId = orderId, OrderType = orderType });
        }

        [Route("destination/{destinationuri}")]
        [Route("destino/{destinationuri}")]
        public async Task<IActionResult> destination(string destinationUri)
        {
            try
            {
                ViewBag.ReadFile = false;
                ViewBag.DestinationUri = destinationUri;
                DestinationRS response = await destinationCore.GetDestination(destinationUri);
                if (response != null)
                {
                    ViewBag.ReadFile = response.ReadFile;
                    var firstCountry = response.Countries?.FirstOrDefault();
                    var firstDestination = firstCountry.Destinations?.FirstOrDefault();
                    //Destination Not Exist
                    if (firstDestination != null)
                    {
                        List<KeyValue> replaceKeys = new List<KeyValue> {
                            new KeyValue { Key = "{CountryName}", Value = firstCountry.Title },
                            new KeyValue { Key = "{DestinationName}", Value = firstDestination.DestinationName }
                        };
                        ViewBag.Metas = HelperMetas.GetMetas(response.Metas?.Metas, "destination", replaceKeys);
                    }
                    else {
                        return View("/Views/Error/Error404.cshtml");
                    }                    
                }
                return View(response);
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = $"Critical exception: {ex.Message}, Trace: {ex.StackTrace}";
                return View("/Views/Error/Error.cshtml");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
