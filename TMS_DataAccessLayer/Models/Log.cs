using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DataAccessLayer.Models
{
    public class Log
    {
        public int LogID { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
