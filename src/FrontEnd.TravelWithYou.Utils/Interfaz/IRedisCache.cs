
using FrontEnd.TravelWithYou.Entities.Web.Cart;

namespace FrontEnd.TravelWithYou.Utils.Interfaz
{
    public interface IRedisCache
    {
        SessionCart GetSessionCartFromRedis(string sessionId, string hash);


        string AddRedisCacheCartHotel(AddCart request);

    }
}
