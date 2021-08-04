﻿using FrontEnd.TravelWithYou.Core.Destinations;
using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using FrontEnd.TravelWithYou.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

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
           DestinationRS response = await destinationCore.GetDestinationsList();
            //response.Countries.All(dt => dt.Destinations.OrderBy(dt => dt.DestinationName).ToList()).ToList();
            return View(response);
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
            ViewBag.DestinationUri = destinationUri;
            DestinationRS response = await destinationCore.GetDestination(destinationUri);
            return View(response);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}