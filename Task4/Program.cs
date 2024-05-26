namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory ();
            inventory.AddProduct("Telefon", 1000);
            inventory.AddProduct("Laptop", 1500);
            inventory.UpdateQuantity("Telefon", 1500);
            Console.WriteLine(inventory.GetQuantityByProduct("Telefon"));
        }
    }
}
