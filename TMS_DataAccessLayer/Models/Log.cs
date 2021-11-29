using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
      * \brief To instantiate Log entity - given a set of attribute values
      * \details <b>Details</b>
      *
      * \Attributes LogID - the ID of the log 
      * \Attributes FileName - the name of the Filename
      * \Attributes CreatedOn - the date on which Attributes
      *
      */
    public class Log
    {
        public int LogID { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
