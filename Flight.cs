using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
  public  class Flight
    {
        private int FlightId;
        public  List<Coupon> Coupons = new List<Coupon>();
        public  FlightNumber flightNumber = new FlightNumber();
     

        public int getFlightId()
        {
            return FlightId;

        }

        public void setFlightId(int id)
        {
            FlightId = id;

        }



    }
}
