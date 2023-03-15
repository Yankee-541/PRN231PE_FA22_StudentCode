using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set;}
        public string TelephoneNumber { get; set;}
        public string ContactName { get; set;}

    }
}
