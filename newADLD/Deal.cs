using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class Deal
    {
        public int purchaseCode;
        public string serialKey;
        public DateTime orderDate;
        public int status;
        public int CouponCode;
        public string customerUserName;
        public double userRank;
        public string store;

        public double price;
        public string name;
        public int daysToUse;

        public Deal(int Ocode, string serial, DateTime order, int cstatus, int Ccode,
            string username, string store, double userRank, double price, string name,
            int daysToUse)
        {
            purchaseCode = Ocode;
            serialKey = serial;
            orderDate = order;
            status = cstatus;
            CouponCode = Ccode;
            customerUserName = username;
            this.userRank = userRank;
            this.store = store;
            this.price = price;
            this.name = name;
            this.daysToUse = daysToUse;
        }

        public string Status()
        {
            if (status == 1)
                return "Ordered";
            else if (status == 2)
                return "Payed";
            else
                return "Used";
                    
        }

    }
}
