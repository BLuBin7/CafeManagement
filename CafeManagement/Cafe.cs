using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementLINQ
{
    public class Cafe {
        public string CafeID { get; set; }
        public string CafeName { get; set; }
        public string CafeType { get; set; }
        public DateTime OpeningDate { get; set; }
        public int Price { get; set; }
        public Cafe()
        {
            CafeID = "Not Assigned";
            CafeName = "Not Assigned";
        }
    }

}
