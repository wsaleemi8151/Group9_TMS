/*
 * Filename:    Customer.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:        November 28, 2021
 * Description: This file contains the class defination for entity Address
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
  * \brief To instantiate Customer entity - given a set of attribute values
  * \details <b>Details</b>
  *
  * \Attributes CompanyName - the Name of Company
  * \Attributes Name - The name of the customer
  * \Attributes CustomerID - The ID of the customer
  * \Attributes CreatedBy - The name of Creater
  * \Attributes CreatedOn - The date on which Customer was created
  * \Attributes UpdatedOn - The date on which Customer was updated
  * \Attributes UpdatedBy - The name by which Customer was updated
  * 
  *
  */
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
