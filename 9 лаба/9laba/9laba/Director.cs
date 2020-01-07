using System;
using System.Collections.Generic;
using System.Text;

namespace _9laba
{
    public class Director
    {
        delegate int Operation(int x, int y);
        public delegate void Message(string Message);
        public event Message Notify2;
        public string Name { get; set; }
        public int Salary { get; set; }
        public int CareerLevel { get; set; }

        public Director(string Name,int Salary, int CareerLevel)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.CareerLevel = CareerLevel;
        }
        public void AddSalary(int money)
        {
            Operation operation = (x, y) => x + y;
            operation(Salary, money);
            Console.ForegroundColor = ConsoleColor.Green;
            Notify2?.Invoke($"Зарплата повышена на {money}$");
            Console.ResetColor();
        }
        public void AddLevel(int level)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Operation operation = (x, y) => x + y;
            operation(CareerLevel, level);
            Notify2?.Invoke($"Уровень в карьерной лестнице увеличен {level}");
            Console.ResetColor();
        }
    }
}
