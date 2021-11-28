using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
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
