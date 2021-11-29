/*
 * Filename:    Invoice.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity Invoice
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
      * \Attributes InvoiceID - the ID of the invoice 
      * \Attributes FeeID - the ID of Fee
      * \Attributes PaymentStatus - The status of the payment
      * \Attributes CreatedBy - The name of Creater
      * \Attributes CreatedOn - The date on which invoice was created
      * \Attributes UpdatedOn - The date on which invoice was updated
      * \Attributes UpdatedBy - The name by which invoice was updated
      * 
      *
      */
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int FeeID { get; set; }
        public string PaymentStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
