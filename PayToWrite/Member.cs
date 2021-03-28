using System;

namespace PayToWrite.Domain
{
    public partial class Member
    {
        public long ID { get; set; }
        public long ChatID { get; set; }
        public Chat Chats { get; set; }

        public long User_Login { get; set; }
        public User Users { get; set; }

        public DateTime CreationTime { get; set; }
        
        
    }
}
