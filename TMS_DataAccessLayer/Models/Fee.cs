using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{

    /**
      * \brief To instantiate Fee entity - given a set of attribute values
      * \details <b>Details</b>
      *
      * \Attributes FeeID - the ID of Fee
      * \Attributes Description - The description of the fees
      * \Attributes Fees - the amount of the fees
      * \Attributes CreatedBy - The name of Creater
      * \Attributes CreatedOn - The date on which Fee amount and ID was created
      * \Attributes UpdatedOn - The date on which Fee amount and ID  was updated
      * \Attributes UpdatedBy - The name by which Fee amount and ID  was updated
      * 
      *
      */
    public class Fee
    {
        public int FeeID { get; set; }
        public string Description { get; set; }
        public double Fees { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
