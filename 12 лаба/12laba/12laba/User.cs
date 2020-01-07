using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12laba
{
    class User : IInterface
    {
        public readonly double K = 23;
        public int Age { get; set; }
        public string Name { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name} Age:{Age}");
        }
    }
}
