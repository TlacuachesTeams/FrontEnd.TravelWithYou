using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using System.Threading.Tasks;

namespace FrontEnd.TravelWithYou.Core.Destinations
{
    public interface IDestinationCore
    {
        public Task<DestinationRS> GetDestinationsList();
        public Task<DestinationRS> GetDestination(string destinationUri);
    }
}
