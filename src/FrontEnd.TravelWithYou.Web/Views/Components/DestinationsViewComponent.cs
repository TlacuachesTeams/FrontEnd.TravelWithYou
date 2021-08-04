using FrontEnd.TravelWithYou.Core.Destinations;
using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

using System.Collections.Generic;
using FrontEnd.TravelWithYou.Entities.Destinations;

namespace FrontEnd.Web.Views.Components
{
    public class DestinationsViewComponent: ViewComponent
    {
        private readonly IDestinationCore destinationCore;
        public DestinationsViewComponent(IDestinationCore destinationCore)
        {
            this.destinationCore = destinationCore;
        }

        public async Task<IViewComponentResult> InvokeAsync(List<Destination> destinations, int orderId, string orderType)
        {
            if (destinations == null) {
                DestinationRS response = await destinationCore.GetDestinationsList();
                destinations = response.Countries.FirstOrDefault().Destinations;
            }            
            switch (orderId) {
                case 1:
                    if (orderType.Equals("A"))
                    {
                        destinations = destinations.OrderBy(dt => dt.DestinationName).ToList();
                    }
                    else {
                        destinations = destinations.OrderByDescending(dt => dt.DestinationName).ToList();
                    }
                    break;
                default:
                    destinations = destinations.OrderBy(dt => dt.DestinationName).ToList();
                    break;
            }            
            return await Task.FromResult((IViewComponentResult)View(destinations));
        }
    }
}
