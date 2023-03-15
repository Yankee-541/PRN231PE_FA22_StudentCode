using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class HRStaff
    {
        public string EmailAddress {get; set;}
        public string Fullname { get; set;}
        public string Password { get; set;}
        public Role Role { get; set;}
    }
}
