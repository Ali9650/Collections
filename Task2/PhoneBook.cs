

namespace Task2
{
    internal class PhoneBook
    {
        public Dictionary<string, string> Contacts { get; set; }


        public PhoneBook()
        {
            Contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name,string phoneNumber)
        {
            Contacts.Add(name, phoneNumber);
        }
        public void RemoveContact(string name)
        {
            Contacts.Remove(name);
        }

        public void GetAllContacts() 
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("Phone book is empty.");
            }
            else
            
                foreach (var contact in Contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }
            }

        public string FindContactByName(string name)
        {
            return Contacts[name].ToString();
        }
        
    }
}
