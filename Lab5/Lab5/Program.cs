using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy cake = new Cake("Cake",2500,25,"Not yummy");
            cake.GetCandyInf();
           
            Console.WriteLine("----------------------------------\n");
            Candy sweets = new Sweets("sweet", 500, 2, " yummy");
            sweets.GetCandyInf();
            
            Console.WriteLine("----------------------------------\n");
            Clock clock = new Clock("Rolex",  "Clock", 100000);
            clock.GetClockInf();
           
            Console.WriteLine("----------------------------------\n");
            Flowers flowers = new Flowers("Vasilki", "Flowers", 5, "blue");
            flowers.GetClockInf();
           
            Console.WriteLine("----------------------------------\n");
            object[] List = new object[] { cake, sweets, clock, flowers};
            foreach (Goods cap in List)
                print.printing(cap);

        }
    }
}
