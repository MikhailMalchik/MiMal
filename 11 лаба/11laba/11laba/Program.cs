using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка по алфавиту");
            string[] Month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var selectedMonth1 = from t in Month
                                orderby t  
                                select t; 
            foreach (string s in selectedMonth1)
                Console.WriteLine(s);
            var selectedMonth6 = Month.OrderByDescending(t => t);
            foreach (string s in selectedMonth6)
                Console.WriteLine(s);
            Console.ReadLine();

            Console.WriteLine("Выборка по длине строки");
            var selectedMonth2 = from t in Month
                                 where t.Length ==8
                                 select t;
            foreach (string s in selectedMonth2)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("Содержит u и длина строки не менее 4");
            var selectedMonth3 = from t in Month
                                 where t.Contains('u') && t.Length >=4
                                 select t;
            foreach (string s in selectedMonth3)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("Содержит летние и зимние месяцы");
            var selectedMonth4 = from t in Month
                                 where t.Contains("January")
                                 || t.Contains("February")
                                 || t.Contains("June")
                                 || t.Contains("July")
                                 || t.Contains("August")
                                 || t.Contains("December")

                                 select t;
            foreach (string s in selectedMonth4)
                Console.WriteLine(s);
            Console.WriteLine();

            Time time1 = new Time(12, 44, 21);
            Time time2 = new Time(11, 11, 0);
            Time time3 = new Time(3, 15, 45);
            Time time4 = new Time(21, 40, 0);
            Time time5 = new Time(6, 55, 30);
            Time time6 = new Time(17, 30, 0);
            Time time7 = new Time(14, 14, 30);
            List<Time> times = new List<Time>();
            times.Add(time1);
            times.Add(time2);
            times.Add(time3);
            times.Add(time4);
            times.Add(time5);
            times.Add(time6);
            times.Add(time7);

            Console.WriteLine("Выборка по заданному времени");
            var selectedTime1 = from t in times
                                 where t.Hour == 12
                                 select t;
            foreach (Time s in selectedTime1)
                Console.WriteLine(s.Hour + "." + s.Minute + "." + s.Second);
            Console.WriteLine();

            Console.WriteLine("Время в котором часы и минуты совпадают");
            var selectedTime2 = from t in times
                                where t.Hour == t.Minute
                                select t;
            Time first = selectedTime2.First();
            Console.WriteLine(first.Hour + "." + first.Minute + "." + first.Second);
            Console.WriteLine();

            Console.WriteLine("Отсортированное время");
            var selectedTime3 = from t in times
                                orderby t
                                select t;
            foreach (Time s in selectedTime3)
                Console.WriteLine(s.Hour + "." + s.Minute + "." + s.Second);
            Console.WriteLine();
            Console.WriteLine("Минимальное время");
            Time min = selectedTime3.Min();
            Console.WriteLine(min.Hour + "." + min.Minute + "." + min.Second);

            Console.WriteLine();
            Console.WriteLine("Объединение коллекций");
            List<Student> students = new List<Student>();
            Student andrey = new Student("Andrey", "11A");
            Student alex = new Student("Alex", "10B");
            Student max = new Student("Max", "11A");
            students.Add(andrey);
            students.Add(alex);
            students.Add(max);
            List<Teacher> teachers = new List<Teacher>();
            Teacher vladimir = new Teacher("Vladimir", "11A");
            Teacher dmitriy = new Teacher("Dminriy", "10A");
            Teacher ann = new Teacher("Ann", "10B");
            teachers.Add(vladimir);
            teachers.Add(dmitriy);
            teachers.Add(ann);


            var result = from st in students
                         join teach in teachers on st.Class equals teach.Class
                         select new { Name = st.Name, Class = st.Class, NameT = teach.NameT };
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Class} ({item.NameT})");
















            Console.Read();
        }
    }
}
