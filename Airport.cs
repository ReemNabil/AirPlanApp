using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
   public class Airport
    {
        public int Id { get => Id; set => Id = value; }
        public string AirportName { get => AirportName; set => AirportName = value; }

        List<FlightNumber> flightNumbers = new List<FlightNumber>();
    }
}
