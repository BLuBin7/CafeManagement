using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopManagement
{
    public enum Sex { Male,Female};
    public class Customer
    {
        public string CustomerID {get; set;}
        public string CustomerName { get; set;}
        public DateTime Birthday { get; set;}
        public Sex Sex { get; set;}

        public Customer()
        {
            CustomerID = "Not Assigned";
        }

        public Customer(string customerID, string customerName, DateTime birthday, Sex sex, Image avatar)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Birthday = birthday;
            Sex = sex;
        }
    }
}
