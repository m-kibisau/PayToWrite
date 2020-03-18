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

        public List<Member> Members { get; set; }
        public List<Message> Messages { get; set; }

        /*public Chat()
        {
            Members = new List<Member>();
            Messages = new List<Message>();
        }*/
    }
}
