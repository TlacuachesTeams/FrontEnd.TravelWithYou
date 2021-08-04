using FrontEnd.TravelWithYou.Entities.Common;
using System;

namespace FrontEnd.TravelWithYou.Utils
{
    public static class StayDefault
    {
        public static string CheckIn(ServiceTypeEnum type)
        {
            var checkIn = GetDateInitial(type);
            return string.Format("{0}-{1}-{2}", checkIn.Year, AddZero(checkIn.Month), AddZero(checkIn.Day));
        }

        public static string CheckOut(ServiceTypeEnum type)
        {
            var checkOut = GetDateInitial(type).AddDays(3);
            return string.Format("{0}-{1}-{2}", checkOut.Year, AddZero(checkOut.Month), AddZero(checkOut.Day));
        }

        private static DateTime GetDateInitial(ServiceTypeEnum type)
        {
            switch (type)
            {
                case ServiceTypeEnum.Package:
                    return DateTime.Now.AddDays(14);
                case ServiceTypeEnum.None:
                case ServiceTypeEnum.Hotel:
                case ServiceTypeEnum.Flight:
                case ServiceTypeEnum.Shuttle:
                case ServiceTypeEnum.Tour:
                case ServiceTypeEnum.Car:
                case ServiceTypeEnum.Insurance:
                default:
                    return DateTime.Now.AddDays(7);
            }
        }
        public static string AddZero(int day) => day < 10 ? string.Format("0{0}", day) : day.ToString();
    }
}
