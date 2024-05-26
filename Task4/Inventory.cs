

namespace Task4
{
    internal class Inventory
    {
        public Dictionary<string, int> Products { get;}
        public Inventory()
        {
            Products = new Dictionary<string, int>();
        }
        public void AddProduct(string productName, int quantity)
        {
            if (!Products.ContainsKey(productName))
            {
                Products[productName] = 0;
            }

            Products[productName] += quantity;
        }

       
        public void RemoveProduct(string productName)
        {
            if (Products.ContainsKey(productName))
            {
                Products.Remove(productName);
            }
        }

        
        public void UpdateQuantity(string productName, int newQuantity)
        {
            if (Products.ContainsKey(productName))
            {
                Products[productName] = newQuantity;
            }
        }


        public int GetQuantityByProduct(string productName)
        {
            return Products.ContainsKey(productName) ? Products[productName] : 0;
        }
    }
}

