using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public int CityID { get; set; }
    }
}
