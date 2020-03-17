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

        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Contact> Contacts1 { get; set; }
        public ICollection<Chat> Chats { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Message> Messages { get; set; }

        public User()
        {
            Contacts = new HashSet<Contact>();
            Contacts1 = new HashSet<Contact>();
            Chats = new HashSet<Chat>();
            Members = new HashSet<Member>();
            Messages = new HashSet<Message>();
        }
    }
}
