/*
 * Filename:    OrderTrip.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity OrderTrip
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
   * \brief To instantiate OrderTrip entity - given a set of attribute values
   * \details <b>Details</b>
   *
   * \Attributes TripID - The ID of the Trip
   * \Attributes OrderID - The ID of the Order
   * \Attributes CarrierID - the ID of the Carrier
   *
   */
    public class OrderTrip
    {
        public int TripID { get; set; }
        public int OrderID { get; set; }
        public int CarrierID { get; set; }
    }
}
