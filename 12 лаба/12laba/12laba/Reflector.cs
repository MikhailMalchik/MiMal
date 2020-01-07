using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace _12laba
{
    class Reflector
    {
        public void InfoInFile(string fullname)
        {
            string writePath = @"D:\text.txt";
            Type myType = Type.GetType(fullname, false, true);
            Console.WriteLine();
            Console.WriteLine("Содержимое класса:");
            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
                }
            }
        }
        public void ClassMethods(string fullname)
        {
            Type myType = Type.GetType(fullname, false, true);
            Console.WriteLine();
            Console.WriteLine("Методы:");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name} ");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");

            }
        }
        public void ClassFieldsAndProperties(string fullname)
        {
            Type myType = Type.GetType(fullname, false, true);
            Console.WriteLine();
            Console.WriteLine("Поля:");
            foreach (FieldInfo field in myType.GetFields())
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Свойства:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} {prop.Name}");
            }
        }
        public void RealisedInterfaces(string fullname)
        {
            Type myType = Type.GetType(fullname, false, true);
            Console.WriteLine();
            Console.WriteLine("Реализованные интерфейсы:");
            foreach (Type i in myType.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }
        }
        public void MethodsWithParam(string fullname, string param)
        {
            Type myType = Type.GetType(fullname, false, true);
            Console.WriteLine();
            Console.WriteLine("Методы c заданными параметрами:");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType.Name == param)
                        Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} ()");
                }
                       
            }
        }
        public void ParamFromFile()
        {
            Console.WriteLine();
            Console.WriteLine("Метод с параметрами из файла:");
            FileStream file1 = new FileStream("D:\\param.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string param = reader.ReadToEnd();
            reader.Close();
            string str = String.Concat("Hello, ", param);
            Console.WriteLine(str);
            

        }
    }
}
