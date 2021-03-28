using System;

namespace PayToWrite.Domain
{
    public partial class Contact
    {
        public long ID { get; set; }
        public long User1 { get; set; }
        public long User2 { get; set; }
        public DateTime CreationTime { get; set; }

        public User Users { get; set; }
        public User Users1 { get; set; }
    }
}
