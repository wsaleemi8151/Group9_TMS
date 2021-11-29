/*
 * Filename:    OrderStatus.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity OrderStatus
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
     * \Attributes OrderStatusID - The ID of the status of the Order
     * \Attributes Status - The order of the status
     * 
     *
     */
    public class OrderStatus
    {
        public int OrderStatusID { get; set; }
        public string Status { get; set; }
    }
}
