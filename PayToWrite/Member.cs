using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Member
    {
        public long ChatID { get; set; }
        public long User_Login { get; set; }

        public User Users { get; set; }
        public Chat Chats { get; set; }
    }
}
