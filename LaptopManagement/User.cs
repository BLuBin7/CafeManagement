using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopManagement
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CustomerID { get; set; }

        public User()
        {
            UserName = "Not Assigned";
        }

        public User(string userName, string password, string customerID)
        {
            UserName = userName;
            Password = password;
            CustomerID = customerID;
        }
    }
}
