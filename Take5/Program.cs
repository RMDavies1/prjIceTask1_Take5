using System;

namespace Take5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Item[] item1 = new Item[5];
                double total = 0.0;
                string str = "";
                try
                {
                    for (int i = 0; i < item1.Length; i++)
                    {
                        Console.Write("Enter the name of the item: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the price of {0}:", name);
                        double price = Convert.ToDouble(Console.ReadLine());
                        total += price;
                        item1[i] = new Item(name, price);
                    }
                    Cart c = new Cart(1.14, total);
                    c.Calculate();
                    for (int i = 0; i < item1.Length; i++)
                    {
                       str += item1[i].Name +"\tR " + item1[i].Price.ToString("F") + "\n";
                    }
                    Console.WriteLine(c.Display(str));


                    Console.WriteLine("\nIf you would like to exit please enter 1; enter any other key to continue.");
                    string exit = Console.ReadLine();
                    switch (exit)
                    {
                        case "1":
                            Terminate();
                                break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format");
                }
                
            }
        }

        private static void Terminate()
        {
            Environment.Exit(0);
        }
    }
}
