using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
      * \brief To instantiate Route entity - given a set of attribute values
      * \details <b>Details</b>
      *
      * \Attributes RouteID - The ID of the Route
      * \Attributes Description - the description of the route
      * \Attributes SourceAddressID - The source  Address ID of the Route
      * \Attibutes DestinationAddressID - The destination Address ID of the Route
      * \Attributes CreatedBy - The name of Creater
      * \Attributes CreatedOn - The date on which Route was created
      * \Attributes UpdatedOn - The date on which Route was updated
      * \Attributes UpdatedBy - The name by which Route was updated
      *
      */
    public class Route
    {
        public int RouteID { get; set; }
        public string Description { get; set; }
        public int SourceAddressID { get; set; }
        public int DestinationAddressID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
