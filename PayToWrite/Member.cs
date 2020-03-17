using System;

namespace PayToWrite.Domain
{
    public partial class Member
    {
        public long ChatID { get; set; }
        public long User_Login { get; set; }
        public DateTime CreationTime { get; set; }
        public User Users { get; set; }
        public Chat Chats { get; set; }
    }
}
