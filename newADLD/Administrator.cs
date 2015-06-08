using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponsSystems
{
    public class Administrator : User
    {
        public string employeeID;

        public Administrator(string userName, string password, string FirstName, string LastName, string eeID)
            : base(userName, password, FirstName, LastName, 3)
        {
            employeeID = eeID;
        }
    }
}
