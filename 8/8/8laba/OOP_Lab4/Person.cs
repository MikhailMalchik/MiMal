﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Info()
        {
                Console.WriteLine($"Name:  + {Name} + ;  + Age:  + {Age}");
        }
    }
}
