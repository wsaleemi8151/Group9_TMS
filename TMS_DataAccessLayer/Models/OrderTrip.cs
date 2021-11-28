using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    public class OrderTrip
    {
        public int TripID { get; set; }
        public int OrderID { get; set; }
        public int CarrierID { get; set; }
    }
}
