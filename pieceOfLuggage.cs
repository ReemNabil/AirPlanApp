using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanApp
{
    public class pieceOfLuggage
    {
        private int Weight;
        private int Id;
        Coupon coupon = new Coupon();

        public pieceOfLuggage( int w , int id  )
        {
            this.Weight = w;
            this.Id = id;
        }

        public int getWeight()
        {
            return Weight;

        }

        public void setWeight(int Weigh)
        {
            Weight = Weigh;


        }
        public int getid()
        {
            return Id;

        }

     
    }
}