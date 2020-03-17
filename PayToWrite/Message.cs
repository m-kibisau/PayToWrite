using System;

namespace PayToWrite.Domain
{
    public partial class Message
    {
        public long ID { get; set; }
        public long ChatID { get; set; }
        public string Text { get; set; }
        public DateTime CreationTime { get; set; }
        public long Autor { get; set; }

        public User Users { get; set; }
        public Chat Chats { get; set; }
        
    }
}
