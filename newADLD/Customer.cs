using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class Customer : User
    {
        public string Email;
        public DateTime DateOfBirth;
        public string Address;
        public string City;
        public string Phone;
        public int Prefrence;
        public DateTime lastTimeNotified;
        int currLocationx;
        int currLocationy;

         /**
         * dob = yyyy-mm-dd
         * 2=fun, 1=restaurant, 4=shopping 3=sports
         * */
        public Customer(string userName, string password, string FirstName, string LastName, string email, DateTime dateOfBirth, string address, string city, string phone, int prefrence) 
            : base(userName, password, FirstName, LastName, 1)
        {
            Email = email;
            DateOfBirth = dateOfBirth;
            Address = address;
            City = city;
            Phone = phone;
            Prefrence = prefrence;
            lastTimeNotified = new DateTime(1900, 1, 1, 0, 0, 0);
            currLocationx = 000000;
            currLocationy = 000000;
        }

        public string getPrefrence()
        {
            if (Prefrence == 2)
                return "Fun";
            else if (Prefrence == 1)
                return "Restaurant";
            else if (Prefrence == 4)
                return "Shopping";
            else
                return "Sports";     
        }
    }
}
