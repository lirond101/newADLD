using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class User
    {
        public string UserName;
        public string FirstName;
        public string LastName;
        public string Password;
        public int type;
        public string UserType;

        /*
         * 3=admin, 1=customer, 2=owner
         */
        public User(string userName, string password, string firstName, string lastName, int type)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            this.type = type;
            UserType = getType();
        }


        public string getType()
        {
            if (type == 3)
                return "Administrator";
            else if (type == 1)
                return "Customer";
            else
                return "Store Owner";
        }
    }


}
