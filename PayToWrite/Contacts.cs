using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Contacts
    {
        public string User1 { get; set; }
        public string User2 { get; set; }
        public DateTime CreationTime { get; set; }

        public Users Users { get; set; }
        public Users Users1 { get; set; }
    }
}
