namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            phoneBook.AddContact("Vaqif", "0506157409");
            phoneBook.AddContact("Ali", "0502505059");
            phoneBook.GetAllContacts();
            Console.WriteLine(phoneBook.FindContactByName("Ali"));
            phoneBook.RemoveContact("Ali");
            phoneBook.GetAllContacts();
        }
    }
}
