using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class StoreOwner : User
    {
        string Email;
        string Phone;

        public StoreOwner(string userName, string password, string FirstName, string LastName, string email, string phone)
            : base(userName, password, FirstName, LastName, 2)
        {
            Email = email;
            Phone = phone;
        }
    }
}
