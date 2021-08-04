using FrontEnd.TravelWithYou.Entities.Api.Destinations;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FrontEnd.TravelWithYou.Data.Destinations
{
    public class DestinationData: IDestinationData
    {        
        public DestinationData() {            
        }

        public async Task<DestinationRS> GetDestinationsList()
        {
            DestinationRS response = new DestinationRS();
            string currentDirectory = System.Environment.CurrentDirectory;
            var filePath = Path.Combine(currentDirectory, "json","destinations.json");
            StreamReader r = new StreamReader(filePath);
            string jsonString = r.ReadToEnd();
            response = JsonConvert.DeserializeObject<DestinationRS>(jsonString);
            return Task.FromResult(response).Result;
        }
    }
}
