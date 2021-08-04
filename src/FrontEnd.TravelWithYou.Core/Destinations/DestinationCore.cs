using System.Threading.Tasks;
using FrontEnd.TravelWithYou.Data.Destinations;
using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using System.Linq;

namespace FrontEnd.TravelWithYou.Core.Destinations
{
    public class DestinationCore: IDestinationCore
    {
        private readonly IDestinationData destinationData;
        public DestinationCore(IDestinationData destinationData) {
            this.destinationData = destinationData;
        }

        public async Task<DestinationRS> GetDestinationsList() {
            return await destinationData.GetDestinationsList();
        }

        public async Task<DestinationRS> GetDestination(string destinationUri)
        {
            DestinationRS response = new DestinationRS();
            var data = await destinationData.GetDestinationsList();
            response.Countries = data.Countries.Select(dt => new Country {
                Title = dt.Title,
                Description = dt.Description,
                Galleries = dt.Galleries,
                Destinations = dt.Destinations.Where(dt=> dt.DestinationUri.ToLower().Equals(destinationUri.ToLower())).OrderBy(dt=> dt.DestinationName).ToList()
            }).ToList();
            return response;
        }
    }
}
