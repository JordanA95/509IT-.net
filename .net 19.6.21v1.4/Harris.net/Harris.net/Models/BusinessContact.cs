using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harris.net.Models
{
    public class BusinessContact
    {
        public int BusinessContactID { get; set; }
        public string BusinessContactFName { get; set; }
        public string BusinessContactLName { get; set; }
        public string BusinessContactEmail { get; set; }
        public string BusinessTel { get; set; }
        public string BusinessContactAddr1 { get; set; }
        public string BusinessContactAddr2 { get; set; }
        public string BusinessContactCity { get; set; }
        public string BusinessContactPostcode { get; set; }
    }
}
