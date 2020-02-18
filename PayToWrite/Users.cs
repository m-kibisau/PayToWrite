using System.Collections.Generic;

namespace PayToWrite.Domain
{
    public class Users
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public decimal Bill { get; set; }

        public ICollection<Contacts> Contacts { get; set; }
        public ICollection<Contacts> Contacts1 { get; set; }
        public ICollection<Chats> Chats { get; set; }
        public ICollection<Members> Members { get; set; }
        public ICollection<Messages> Messages { get; set; }

        public Users()
        {
            Contacts = new List<Contacts>();
            Contacts1 = new List<Contacts>();
            Chats = new List<Chats>();
            Members = new List<Members>();
            Messages = new List<Messages>();
        }
    }
}
