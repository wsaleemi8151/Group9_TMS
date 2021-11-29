/*
 * Filename:    Country.cs
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file contains the class defination for entity Country
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    /**
* \brief To instantiate Country entity - given a set of attribute values
* \details <b>Details</b>
*
* \Attributes CountryID - the ID of Country
* \Attributes CountryName- the name of Country
* 
*
*/
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
