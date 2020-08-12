using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
   public  class Customer 
    {
         private string CustomerName;
         private int CustomerId;
         List<Ticket> tickets = new List<Ticket>();
        public Customer(string CustomerName , int CustomerId)
        {
            this.CustomerName = CustomerName;
            this.CustomerId = CustomerId;
        }
       
        public List<Ticket> RetrieveTicketsById(int id)
        {
            if (id == CustomerId)
            {
                foreach (Ticket T in this.tickets)
                {

                    Console.WriteLine("Tickets :- " + T.getTicketId());
                    Console.WriteLine("Coupons :- " + T.getcoupon());


                }
                return tickets;
               
            }
            else
            {
                return new List<Ticket>();
            }
                  
        }
        public string  getCustomerName()
        {
            return CustomerName;

        }

        public void setCustomerId(int id )
        {
            CustomerId = id ;

        }
        public int getCustomerId()
        {
            return CustomerId;

        }

        public void setCustomerName(string name)
        {
            CustomerName = name;

        }

    }
}
