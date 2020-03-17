using System;
using System.Collections.Generic;

namespace PayToWrite.Domain
{
    public partial class Chat
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long Creator { get; set; }
        public DateTime CreationTime { get; set; }

        public virtual User Users { get; set; }

        public ICollection<Member> Members { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Chat()
        {
            Members = new HashSet<Member>();
            Messages = new HashSet<Message>();
        }
    }
}
