using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
  public   class FlightNumber
    {

        public int Departure { get => Departure; set => Departure = value; }
        public string Description { get => Description; set => Description = value; }
        public string Airline { get => Airline; set => Airline = value; }

        public List<Flight> flights; 

        public  Airport airport;
        // compostion
        public FlightNumber()
        {
            airport = new Airport();
            flights = new List<Flight>();
        }


    }
}
