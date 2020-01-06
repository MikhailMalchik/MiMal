using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class lab3
    {
        static void Main(string[] args)
        {
            object[] CARS = new object[7] { new Car(56,"Audi", "13ggferf", 2015, "grey", 2000, 1393238),
                                            new Car(75,"BMW", "17fasfs", 2019, "yellow", 60000, 1234421),
                                            new Car(38, "Жигуль", "228nn", 1985, "white", 5, 1234312),
                                            new Car(432,"BMW", "wdf23f", 2001, "black", 1500, 1232993),
                                            new Car(39,"Audi", "8udddja", 2005, "white", 8000, 7234911),
                                            new Car(009,"Toyota", "17fasfs", 2019, "yellow", 60000, 1234421),
                                            new Car(433,"BMW", "17fasfs", 2019, "yellow", 60000, 1234421) };
            Car.showInf();
            Console.WriteLine("Введите марку: ");
            string x = Console.ReadLine();
            Console.WriteLine("Список автомобилей заданной марки: ");
            foreach (Car mobile in CARS)
            {
                if (mobile.MARK == x)
                    Console.WriteLine(mobile.ID + "\t" + mobile.MARK + "\t" + mobile.MODEL + "\t" + mobile.YEAR + "\t" + mobile.COLOR + "\t" + mobile.PRICE + "\t" + mobile.REGNUMB );
            }
            Console.WriteLine("Введите кол-во лет эксплуатации: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Список машин нужного возраста: ");
            foreach (Car mobile in CARS)
            {
                if ((2019 - mobile.YEAR) <= y )
                    Console.WriteLine(mobile.ID + "\t" + mobile.MARK + "\t" + mobile.MODEL + "\t" + mobile.YEAR + "\t" + mobile.COLOR + "\t" + mobile.PRICE + "\t" + mobile.REGNUMB);
            }
            
            Console.WriteLine(Equals(CARS[0], CARS[1]));
            Console.WriteLine(CARS.Equals(CARS));
        }
    }

    public partial class Car
    {
        private static int tableSize = 0;
        public static void showInf()
        {
            Console.WriteLine("Size: " + tableSize);
        }
        private int ident;
        private string mark = "";
        private string mod = "";
        private int year;
        private string color = "";
        private int price;
        private int regnumb;

        public int ID
        {
            get { return this.ident; }
            set { this.ident = value; }
        }
        public string MARK
        {
            get { return this.mark; }
            set { this.mark = value; }
        }
        public string MODEL
        {
            get { return this.mod; }
            set { this.mod = value; }
        }
        public int YEAR
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public string COLOR
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int PRICE
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int REGNUMB
        {
            get { return this.regnumb; }
            set { this.regnumb = value; }
        }




        public Car(int id, string mark, string model, int year, string color, int price, int regnumb)                                                                //first constructor
        {
            this.ident = id;
            this.mark = mark;
            this.mod = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.regnumb = regnumb;
            Car.tableSize++;
        }
        
         

            
        
    }
}