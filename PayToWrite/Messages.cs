using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Messages
    {
        public long ID { get; set; }
        public long ChatID { get; set; }
        public string Text { get; set; }
        public DateTime CreationTime { get; set; }
        public string Autor { get; set; }

        public Users Users { get; set; }
        public Chats Chats { get; set; }
        
    }
}
