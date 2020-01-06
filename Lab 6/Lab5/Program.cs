using System;

namespace Lab6
{
    class Program
    {
        enum kod
        {
            Mon = 1, Tye, Wen, Fri
        };
        struct not
        {
            public void kk()
            {
                Console.WriteLine("struct");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine(kod.Mon);
            not gg = new not();
            gg.kk();
        Candy cake = new Cake("Cake", 2500, 25, "Not yummy", 4);

        cake.GetCandyInf();
        
            Console.WriteLine("----------------------------------\n");
            Candy sweets = new Sweets("sweet", 500, 2, " yummy", 1);
        sweets.GetCandyInf();
            
            Console.WriteLine("----------------------------------\n");
            Clock clock = new Clock("Rolex", "Clock", 100000, 2);
        clock.GetClockInf();
           
            Console.WriteLine("----------------------------------\n");
            Flowers flowers = new Flowers("Vasilki", "Flowers", 5, "blue", 3);
            flowers.GetClockInf();
           
            Console.WriteLine("----------------------------------\n");
            Goods [] List = new Goods[] { cake, sweets, clock, flowers };
            int i;
            Goods a = cake;
            Goods b = sweets;
            Goods c= flowers;
            for (i=0; i<4;i++)
            {
                for (i = 0; i < 3; i++)
                {
                    a = List[i];
                    if (List[i + 1] != null)
                        b = List[i + 1];

                    if (a.Size > b.Size)
                    {
                        c = List[i];
                        List[i] = List[i + 1];
                        List[i + 1] = c;
                    }
                }
            }
            present Kop = new present();
            Kop.Add(cake);
            Kop.Add(clock);

            foreach (Goods cap in List)
            {
                print.printing(cap);
                Console.WriteLine(cap.Size);

            }

        }
    }
}
