using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class City
    {
        public string name;
        public int tlx;
        public int tly;
        public int brx;
        public int bry;

        public City(string name, int tlx, int tly, int brx, int bry)
        {
           this.name = name;
           this.tlx = tlx;
           this.tly = tly;
           this.brx = brx;
           this.bry = bry;
        }
    }
}
