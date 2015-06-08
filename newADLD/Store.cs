using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class Store
    {
        public string storeID;
        public string name;
        public string description;
        public string address;
        public int catagory;
        public string city;
        public string phoneNum;
        public double rank;
        public string OwnerUserName;

        public Store(string storeid, string Name, string Desc, string Address, int catagory,
            string City, string PhoneNumber, double rank, string ownerUserName)
        {
            storeID = storeid;
            name = Name;
            description = Desc;
            address = Address;
            this.catagory = catagory;
            city = City;
            phoneNum = PhoneNumber;
            this.rank = rank;
            OwnerUserName = ownerUserName;
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
