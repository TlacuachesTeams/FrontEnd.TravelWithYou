using FrontEnd.TravelWithYou.Utils.Interfaz;
using StackExchange.Redis;
using System;
using System.Threading;

namespace FrontEnd.TravelWithYou.Utils
{
    /// <summary>
    /// RedisConnectorHelper class
    /// </summary>
    public class RedisHelper : IRedisHelper
    {
        private readonly Lazy<ConnectionMultiplexer> connectionMultiplexer;

        public RedisHelper()
        {
            var configurationOptions = ConfigurationOptions.Parse(Environment.GetEnvironmentVariable("REDIS_CACHE"));
            configurationOptions.SyncTimeout = Convert.ToInt32(Environment.GetEnvironmentVariable("REDIS_TIME"));
            connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(configurationOptions), LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public IDatabase Database
        {
            get
            {
                return connectionMultiplexer.Value.GetDatabase(0);
            }
        }
    }
}
