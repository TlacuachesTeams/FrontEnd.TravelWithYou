using FrontEnd.TravelWithYou.Entities.Common;
using System.Collections.Generic;
using System.Linq;

namespace FrontEnd.TravelWithYou.Utils
{
    public static class Transform
    {

        public static SearchPaxes CreateOccupancy(string occupancy)
        {
            int adults = 0;
            int children = 0;
            int rooms = 0;
            string childrenAges = string.Empty;
            List<Occupancy> occupancies = new List<Occupancy>();
            try
            {
                foreach (string room in occupancy.Split('!'))
                {
                    Occupancy request = new Occupancy()
                    {
                        Rooms = 1
                    };
                    request.Paxes = new List<Pax>();
                    string[] person = room.Split('-');
                    request.Adults = int.Parse(person[0]);
                    request.Children = person.Length - 1;
                    //Acumulado
                    rooms += request.Rooms;
                    adults += request.Adults;
                    children += request.Children;
                    for (int i = 0; i < request.Adults; i++)
                    {
                        Pax paxes = new Pax()
                        {
                            Age = 21,
                            RoomId = 1,
                            Type = "ADT"
                        };
                        request.Paxes.Add(paxes);
                    }
                    for (int i = 0; i < request.Children; i++)
                    {
                        Pax paxes = new Pax()
                        {
                            Age = int.Parse(person[i + 1]),
                            RoomId = 1,
                            Type = "CHD"
                        };
                        request.Paxes.Add(paxes);
                    }
                    occupancies.Add(request);
                }
            }
            catch
            {
                var oOccupancy = new Occupancy()
                {
                    Rooms = 1,
                    Adults = 2,
                    Children = 0,
                    Paxes = new List<Pax>(){
                        new Pax(){Age=21, RoomId=1,Type="ADT"},
                        new Pax(){Age=21, RoomId=1, Type="ADT"}
                    }
                };
                rooms = oOccupancy.Rooms;
                adults = oOccupancy.Adults;
                children = oOccupancy.Children;
                occupancies.Add(oOccupancy);
            }
            //Solo si hay niños
            if (children > 0)
            {
                List<string> ages = new List<string>();
                if (occupancies != null && occupancies.Count > 0)
                {
                    foreach (var objOc in occupancies)
                    {
                        foreach (var pax in objOc.Paxes.Where(px => px.Type.Equals("CHD")))
                        {
                            ages.Add(pax.Age.ToString());
                        }
                    }
                }
                childrenAges = string.Join(",", ages.ToArray());
            }
            SearchPaxes searchPaxes = new SearchPaxes
            {
                TotalRooms = rooms,
                TotalAdults = adults,
                TotalChildren = children,
                ChildrenAges = childrenAges,
                PaxesOccupancy = occupancies
            };
            return searchPaxes;
        }
    }
}
