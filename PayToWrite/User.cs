using System.Collections.Generic;

namespace PayToWrite.Domain
{
    public partial class User
    {
        public long ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public decimal Bill { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<Contact> Contacts1 { get; set; }
        public List<Chat> Chats { get; set; }
        public List<Member> Members { get; set; }
        public List<Message> Messages { get; set; }

        /*public User()
        {
            Contacts = new List<Contact>();
            Contacts1 = new List<Contact>();
            Chats = new List<Chat>();
            Members = new List<Member>();
            Messages = new List<Message>();
        }*/
    }
}
