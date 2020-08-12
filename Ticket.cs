using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
  public  class Ticket
    {
        private int TicketId;
        Coupon coupon;

        //Aggregation
        public Ticket( int id , Coupon coupon)
        {
            this.TicketId = id;
            this.coupon = coupon;
        }

        public Coupon getcoupon()
        {
            return coupon;

        }

        public int getTicketId()
        {
            return TicketId;

        }

        public void setTicketId(int id)
        {
            TicketId = id;

        }
    }
}
