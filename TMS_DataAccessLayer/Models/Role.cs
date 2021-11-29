/*
 * Filename:    Role.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity Role
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{

    /**
   * \brief To instantiate Role entity - given a set of attribute values
   * \details <b>Details</b>
   *
   * \Attributes RoleID - The ID of the Role
   * \Attributes RoleName - the name of the role
   *
   */
    class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
