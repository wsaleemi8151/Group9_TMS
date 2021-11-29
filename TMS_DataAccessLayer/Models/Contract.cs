using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{

    /**
    * \brief To instantiate Contract entity - given a set of attribute values
    * \details <b>Details</b>
    *
    * \Attributes ContractID - the ID of Contract
    * \Attributes ContractDetails - the details of the contract
    * \Attributes CustomerID - The ID of the customer
    * \Attributes CreatedBy - The name of Creater
    * \Attributes CreatedOn - The date on which Contract was created
    * \Attributes UpdatedOn - The date on which Contract was updated
    * \Attributes UpdatedBy - The name by which Contract was updated
    * 
    *
    */
    public class Contract
    {
        public int ContractID { get; set; }
        public string ContractDetails { get; set; }
        public int CustomerID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
