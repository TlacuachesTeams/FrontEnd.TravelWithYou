using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using System.Threading.Tasks;

namespace FrontEnd.TravelWithYou.Data.Destinations
{
    public interface IDestinationData
    {
        public Task<DestinationRS> GetDestinationsList();
    }
}
