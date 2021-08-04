using FrontEnd.TravelWithYou.Entities.Web.Cart;
using FrontEnd.TravelWithYou.Entities.Web.Common;
using FrontEnd.TravelWithYou.Utils.Interfaz;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrontEnd.TravelWithYou.Utils
{
    public class RedisCache: IRedisCache
    {        
        private readonly IRedisHelper redis;
       
        public RedisCache(           
            IRedisHelper redis
        ) {
            this.redis = redis;          
        }

        /// <summary>
        /// Get Redis
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public SessionCart GetSessionCartFromRedis(string sessionId, string hash)
        {
            SessionCart cart = null;           
            try
            {
                GlobalSetting response = null;
                string redisKeySite = Environment.GetEnvironmentVariable("SiteSettings");
                string stringRedis = redis.Database.StringGet($"{redisKeySite}{sessionId}");
                if (stringRedis != null)
                {
                    response = JsonConvert.DeserializeObject<GlobalSetting>(stringRedis);
                }
            }
            catch (Exception ex) {
                var x = ex.Message;
            }          
            return cart;
        }
              

        public string AddRedisCacheCartHotel(AddCart request)
        {
            string hotelPriceHash = string.Empty;
            //if (request != null && request.Hotels != null) {
            //    hotelPriceHash = request.Hash;  //El que ya trae en la url            
            //    //List<SpecialRestriction> specialRestrictions = new List<SpecialRestriction>();
            //    if (request.Hotels != null)
            //    {
            //        //request.Hotels.Margin = request.Hotel.Margin > 1
            //        //    ? request.Hotel.Margin / 100
            //        //    : request.Hotel.Margin;

            //        ////No inluyo como parte del hash
            //        //request.Hotel.OriginalMargin = request.Hotel.OriginalMargin > 1
            //        //    ? request.Hotel.OriginalMargin / 100
            //        //    : request.Hotel.OriginalMargin;

            //        //hotelPriceHash = HashGenerator.CreateMD5(JsonConvert.SerializeObject(new HashParameters
            //        //{
            //        //    HotelId = request.Hotel.HotelId,
            //        //    CheckIn = request.Hotel.CheckIn,
            //        //    CheckOut = request.Hotel.CheckOut,
            //        //    Occupancy = request.Hotel.Occupancy,
            //        //    HotelUri = request.Hotel.HotelUri,
            //        //    DestinationUri = request.Hotel.DestinationUri
            //        //}));
            //    }

            //    SiteModel siteModel = GetRedisCache(request.SessionId);
            //    //request.Hotels.Hash = hotelPriceHash;
            //    request.Hash = hotelPriceHash;
            //    //Ya hay registros en el carrito
            //    if (siteModel.Cart.Hotels != null)
            //    {
            //        siteModel.Cart.Hotels.ForEach(ht => {
            //            if (ht.Hash == null)
            //            {
            //                ht.Hash = string.Empty;
            //            }
            //        });
            //        var exist = siteModel.Cart.Hotels.Exists(x => x.Hash.Equals(hotelPriceHash));
            //        if (exist == true)
            //        {
            //            var index = siteModel.Cart.Hotels.FindIndex(x => x.Hash.Equals(hotelPriceHash));
            //            //siteModel.Cart.Hotels[index] = request.Hotels;  //Existe sobreescribe valores                    
            //        }
            //        else
            //        {
            //            //Agrega nuevo                   
            //            siteModel.Cart.Hotels.AddRange(request.Hotels);
            //        }
            //    }
            //    else
            //    {
            //        //siteModel.Cart.Hotels = new List<HotelCart>
            //        //{
            //        //    request.Hotels
            //        //};
            //    }
            //    AddRedisCache(request.SessionId, siteModel);
            //}
            return hotelPriceHash; 
        }       
               
    }
}
