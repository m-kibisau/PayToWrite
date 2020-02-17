using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Chats
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public DateTime CreationTime { get; set; }

        public Users Users { get; set; }

        public ICollection<Members> Members { get; set; }
        public ICollection<Messages> Messages { get; set; }

        public Chats()
        {
            Members = new List<Members>();
            Messages = new List<Messages>();
        }
    }
}
