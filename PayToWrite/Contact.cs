using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Contact
    {
        public long User1 { get; set; }
        public long User2 { get; set; }
        public DateTime CreationTime { get; set; }

        public User Users { get; set; }
        public User Users1 { get; set; }
    }
}
