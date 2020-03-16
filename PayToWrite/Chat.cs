﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Chat
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long Creator { get; set; }
        public DateTime CreationTime { get; set; }

        public User Users { get; set; }

        public ICollection<Member> Members { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Chat()
        {
            Members = new List<Member>();
            Messages = new List<Message>();
        }
    }
}
