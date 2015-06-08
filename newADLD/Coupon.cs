using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class Coupon
    {
        public int Code;
        public string Name;
        public string Description;
        public string Store;
        public double originalPrice = 0;
        public double discountPrice = 0;
        public int daysValid = 0;
        public DateTime deadline = DateTime.Today;
        public double couponRank = 0;
        public int numOfRanks = 0;
        public int approved = 0;
        public int catagory;
        public string city;

        public Coupon(int code, string name, string description, string store, double origininalPrice, double discountPrice,
            int daysValid, DateTime ddline, double rank, int numRanks, int approved, int catagory, string city)
        {
            Code = code;
            Name = name;
            Description = description;
            Store = store;
            this.originalPrice = origininalPrice;
            this.discountPrice = discountPrice;
            this.daysValid = daysValid;
            deadline = ddline;
            couponRank = rank;
            numOfRanks = numRanks;
            this.approved = approved;
            this.catagory = catagory;
            this.city = city;
        }

        public string getPrefrence()
        {
            if (catagory == 2)
                return "Fun";
            else if (catagory == 1)
                return "Restaurant";
            else if (catagory == 4)
                return "Shopping";
            else
                return "Sports";
        }
    }
}
