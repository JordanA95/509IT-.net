using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harris.net.Models
{
    //PersonalContact Model specifying all fields for Personal Contacts table in the database.
    public class PersonalContact
    {
        public int PersonalContactID { get; set; }
        public string PersonalContactFName { get; set; }
        public string PersonalContactLName { get; set; }
        public string PersonalContactEmail { get; set; }
        public string PersonalTel { get; set; }
        public string PersonalContactAddr1 { get; set; }
        public string PersonalContactAddr2 { get; set; }
        public string PersonalContactCity { get; set; }
        public string PersonalContactPostcode { get; set; }

    }
}
