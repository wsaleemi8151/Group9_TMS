/*
 * Filename:    CustomerOrder.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity CustomerOrder
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
      * \brief To instantiate CustomerOrder entity - given a set of attribute values
      * \details <b>Details</b>
      *
      * \Attributes OrderID - the ID of Order
      * \Attributes OrderDetails - The deatils of the Order
      * \Attributes OrderStatusID - The ID of the status of the Order
      * \Attributes CustomerID - The ID of the customer
      * \Attributes CarrierID - the ID of Carrier
      * \Attributes InvoiceID - the ID of the invoice 
      * \Attributes CreatedBy - The name of Creater
      * \Attributes CreatedOn - The date on which CustomerOrder was created
      * \Attributes UpdatedOn - The date on which CustomerOrder was updated
      * \Attributes UpdatedBy - The name by which CustomerOrder was updated
      * 
      *
      */
    public class CustomerOrder
    {
        public int OrderID { get; set; }
        public string OrderDetails { get; set; }
        public int OrderStatusID { get; set; }
        public int CustomerID { get; set; }
        public int CarrierID { get; set; }
        public int InvoiceID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
