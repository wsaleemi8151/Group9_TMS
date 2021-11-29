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
    * \Attributes CountryID - the ID of Country
    * \Attributes StateName- the name of State
    * 
    *
    */
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int CountryID { get; set; }
    }
}
