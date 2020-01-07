using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _12laba
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("Andrey", 18);
            Reflector reflector = new Reflector();
            reflector.InfoInFile("_12laba.User");
            reflector.ClassMethods("_12laba.User");
            reflector.ClassFieldsAndProperties("_12laba.User");
            reflector.RealisedInterfaces("_12laba.User");
            reflector.MethodsWithParam("_12laba.User", "String");
            //reflector.ParamFromFile();

            Console.ReadLine();
        }
    }
}
