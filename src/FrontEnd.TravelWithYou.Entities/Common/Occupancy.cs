using System.Collections.Generic;
namespace FrontEnd.TravelWithYou.Entities.Common
{
    public class Occupancy
    {
        public int Rooms { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public List<Pax> Paxes { get; set; }
    }
}
