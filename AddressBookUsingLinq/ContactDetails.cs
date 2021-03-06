using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    public class ContactDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public double phoneNumber { get; set; }
        public int zipCode { get; set; }
        public string emailId { get; set; }

        public string addressBookName { get; set; }
        public string addressBookType { get; set; }
    }
}
