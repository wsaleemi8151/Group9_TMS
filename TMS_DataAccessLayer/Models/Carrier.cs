/*
 * Filename:    Carrier.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity Carrier
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{

    /**
    * \brief To instantiate Carrier entity - given a set of attribute values
    * \details <b>Details</b>
    *
    * \Attributes CarrierID - the ID of Carrier
    * \Attributes Name - the Name of Carrier
    * \Attributes VehicleDimensions- The dimensions of the vehicle
    * \Attributes CreatedBy - The name of Creater
    * \Attributes CreatedOn - The date on which Carrier was created
    * \Attributes UpdatedOn - The date on which Carrier was updated
    * \Attributes UpdatedBy - The name by which Carrier was updated
    * 
    *
    */
    public class Carrier
    {
        public int CarrierID { get; set; }
        public string Name { get; set; }
        public string VehicleDimensions { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
