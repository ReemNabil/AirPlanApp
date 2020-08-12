using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
   public class Coupon
    {
        private int CouponId;
        Flight flight = new Flight() ;
        List<pieceOfLuggage> LuggageLst = new List<pieceOfLuggage> ();

      //  Retrieve Coupon details and Flights under it if exist and Flight number details and Airport information

            public string RetrieveCouponDetails()
        {
            return "CouponId is " + CouponId + "Flights is " + flight.getFlightId() + "Flight Number  is "
                + flight.flightNumber + "Airport information is  " + flight.flightNumber.airport.AirportName ;
         
        }
        public int getCouponId()
        {
            return CouponId;

        }

        public void setCouponId(int id)
        {
            CouponId = id;

        }
    
}
}
