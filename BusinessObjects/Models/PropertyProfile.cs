using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class PropertyProfile
    {
        public int PropertyProfileID { get; set; }

        public string Name { get; set;}
        public string ShortDescription { get; set;}
       
        public double Price { get; set;}
        public string Location { get; set; }
        public string PropertyDescription { get; set; }
        public bool Status { get; set; }
    }
}
