/*
 * Filename:    User.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity User
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
      * \Attributes UserID - the ID of the User
      * \Attributes UserName - the name of the User
      * \Attributes Password - the password of the User
      * \Attributes FirstName - the FirstName of the User
      * \Attributes LastName - LastName of the User
      * \Attributes RoleID - The ID of the Role
      * \Attributes CreatedBy - The name of Creater
      * \Attributes CreatedOn - The date on which User was created
      * \Attributes UpdatedOn - The date on which User was updated
      * \Attributes UpdatedBy - The name by which User was updated
      *
      */
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
