using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Domain
{
    public class Members
    {
        public long ChatID { get; set; }
        public string User_Login { get; set; }

        public Users Users { get; set; }
        public Chats Chats { get; set; }
    }
}
