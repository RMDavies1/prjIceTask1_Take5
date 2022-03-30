namespace Take5
{
    internal class Item
    {
        public Item()
        {
        }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

    }
}