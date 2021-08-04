using FrontEnd.TravelWithYou.Entities.Web.Cars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class CarsController: BaseController
    {

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger) : base()
        {
            _logger = logger;
        }

        [Route("autos/{destinatonuri}/")]
        [Route("autos/{destinatonuri}/{checkin}/{checkout}")]
        [Route("autos/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("autos/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("cars/{destinatonuri}/")]
        [Route("cars/{destinatonuri}/{checkin}/{checkout}")]
        [Route("cars/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("cars/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]        
        public IActionResult Index([FromRoute] CarsRQ request, [FromQuery] string sid)
        {
            return View();
        }
    }
}
