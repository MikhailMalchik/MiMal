using System;

namespace _9laba
{
    public delegate void Methods();
   
    public delegate void Message(Director person);
   
    class Program
    {
        public static void Penalty(Director person)
        {
            int penalty = person.CareerLevel * 100;
            person.Salary = person.Salary - penalty;
        }
        public static void Promotion(Director person)
        {
            int level = 1;
            int SalaryRaise = 200;
            person.CareerLevel = person.CareerLevel + level;
            person.Salary = person.Salary + SalaryRaise;
        }
        

        static void Main(string[] args)
        {
            Message mes;
            Director Andrey = new Director("Andrey", 2000, 3);
            Director Alex = new Director("Alex", 1000, 1);
            Director Sam = new Director("Sam", 1500, 2);
            Director person = new Director(" ", 0, 0);

            try
            {
                Console.WriteLine("Выберите работника(1-3)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        person = Andrey;
                        break;
                    case 2:
                        person = Alex;
                        break;
                    case 3:
                        person = Sam;
                        break;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка");
            }
             
            
            Console.WriteLine("Что сделать с работником?");
            Console.WriteLine("Повысить (1); Оштрафовать(2); Оба события(3)");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    mes = Promotion;
                    mes(person);
                    break;
                case 2:
                    mes = Penalty;
                    mes(person);
                    break;
                case 3:
                    mes = Penalty;
                    mes(person);
                    mes = Promotion;
                    mes(person);
                    break;
                default: Console.Clear(); break;
            }
            Console.WriteLine(person.Name+ ": новая зарплата - " + person.Salary + "$");
            Console.WriteLine(person.Name + ": новый уровень в карьерной лестнице - " + person.CareerLevel);

            StringMethods test = new StringMethods();
            test.CurrentString = "Тестовая,   строка,   привет   ААББВВ.";
            Console.WriteLine(test.CurrentString);
            Methods Methods = test.DeleteCommas;
            Methods += test.RemoveSpaces;
            Methods += test.ToUpperCase;
            Methods();
            Console.WriteLine(test.CurrentString);

        }
    }
}
