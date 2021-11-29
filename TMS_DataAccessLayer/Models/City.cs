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
  * \Attributes StateID - the ID of sate
  * \Attributes CityID - the ID of City
  * \Attributes CityName- the name of City
  * 
  *
  */
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StateID { get; set; }
    }
}
