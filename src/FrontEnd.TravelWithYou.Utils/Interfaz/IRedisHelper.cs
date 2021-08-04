using StackExchange.Redis;

namespace FrontEnd.TravelWithYou.Utils.Interfaz
{
    public interface IRedisHelper
    {
        IDatabase Database { get; }
    }
}
