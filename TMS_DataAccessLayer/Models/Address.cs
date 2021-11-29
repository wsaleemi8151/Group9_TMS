using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
    * \brief To instantiate address entity - given a set of attribute values
    * \details <b>Details</b>
    *
    * \Attributes AddressID - the ID of address
    * \Attributes CityID - the ID of City
    * \Attributes StreetAddress - the address of Street
    * 
    *
    */
    public class Address
    {
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public int CityID { get; set; }
    }
}
