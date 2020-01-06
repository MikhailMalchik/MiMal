using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -5;
            uint ux = 5;
            float y = 5;
            double z = 5.5;
            bool truefalse = true;
            byte bite = 244;
            sbyte sbite = -64;
            short shert = -4333;
            ushort ushert = 4933;
            long lenth = -1134134234;
            ulong ulenth = 3453452234;
            decimal dess = 383 / 2;
            char cher = 'a';
            object obj = "No future";
                int num1 = 12;
                int num2 = 13;
                int num3 = 14;
                int num4 = 15;
                int num5 = 16;

                float filt1 = 12.3F;
                float filt2 = 13.3F;
                float filt3 = 14.3F;
                float filt4 = 15.3F;
                float filt5 = 16.3F;

                double deblel1 = 1.5;
                double deblel2 = 2.5;
                double deblel3 = 3.5;
                double deblel4 = 4.5;
                double deblel5 = 5.5;
                // явные
                num1 = (int)filt1;
                filt1 = (float)deblel1;
                num2 = (int)deblel2;
                deblel1 = (double)num3;
                filt2 = (float)deblel4;

                // неявные 
                filt3 = num3;
                deblel2 = filt4;
                deblel3 = filt2;
                deblel4 = num3;
                filt2 = num2;
                // c. Выполните упаковку и распаковку значимых типов.
                Object Something = num1;
                num2 = (int)Something;

                // d. Продемонстрируйте работу с неявно типизированнй переменной.
                var num6 = 3;
                Console.WriteLine(num6.GetType().ToString());

                // e. Продемонстрируйте пример работы с Nullable переменной.
                int? i = null;


                // 2) Строки

                string str1 = "str 1 kkss kkkss";
                string str2 = "str 2";
                string str3 = "str 3";
                string str4 = "str 4";
                string str5 = "str 5";

                char[] gse = str2.ToArray();
                foreach (char item in gse)
                { Console.WriteLine(item); }

                float abc = 5;
                Convert.ToInt16(abc);


                // a.Объявите строковые литералы.Сравните их.
                if (str1 == str2)
                {
                    Console.WriteLine("Строки равны");
                }
                else
                {
                    Console.WriteLine("Строки не равны");
                }

                // b.Создайте три строки на основе String. Выполните: сцепление+, копирование+, выделение подстроки+, 
                //      разделение строки на слова, вставки подстроки в заданную позицию+, удаление заданной подстроки+.
                str4 = str1 + " " + str2;
                str4 = str4.Insert(3, "ing");
                string[] words = str5.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                str4 = str4.Remove(0, 2);
                str4 = str1.Substring(2, 4); 
                str4.Contains("str");

                // c.Создайте пустую и null строку.Продемонстрируйте что можно выполнить с такими строками
                string str6 = "";
                string str7 = null;

                if (str7 == null)
                {
                    Console.WriteLine("Поле не заполнено");
                }

                // d.Создайте строку на основе StringBuilder.Удалите определенные позиции и добавьте новые символы в начало и конец строки.
                StringBuilder myStringBuilder = new StringBuilder("Мда ");
                myStringBuilder.Remove(0, 2);
                myStringBuilder.Append("Ну и добавил и что");
                myStringBuilder.Insert(0, "в начало ");
                myStringBuilder.Insert(myStringBuilder.Length, "!");
                Console.WriteLine(myStringBuilder);


                // 3) Массивы
                //a.Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 
                int n = 3;
                int m = 3;
                int[,] mas = new int[n, m];

                Random rand = new Random();

                for (int c = 0; c < n; c++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[c, j] = rand.Next(1, 9);
                    }
                }

                for (int c = 0; c < n; c++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write(String.Format("{0,2}", mas[c, j]));
                    Console.WriteLine();
                }
                Console.WriteLine();

                // b.Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
                //            Поменяйте произвольный элемент(пользователь определяет позицию и значение).
                int[] array = new int[5] { 1, 2, 3, 4, 5 };

                foreach (int item in array)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();

                Console.WriteLine("Введите индекс элемента и новое значение");
                int index = -1;
                while (index < 0 || index > array.Length)
                {
                    index = int.Parse(Console.ReadLine());
                }
                int value = int.Parse(Console.ReadLine());
                array[index - 1] = value;

                foreach (int item in array)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();

                // d.Создайте неявно типизированные переменные для хранения массива и строки
                var someArray = array;
                var someString = str1;

                // 4) Кортежи
                // a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
                // b.Сделайте именование его элементов.
                (int, string, char, string, ulong) tuple = (a: 4, b: "Tom", c: 'a', d: "string", e: 56);

                // c.Выведите кортеж на консоль целиком и выборочно(1, 3, 4  элементы)
                Console.WriteLine("{0} {1} {2} {3} {4}", tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
                Console.WriteLine("{0} {1} {2}", tuple.Item1, tuple.Item3, tuple.Item4);

                // d.Выполните распаковку кортежа в переменные
                (var a, var b, var v, var d, var e) = (tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);

                // e.Сравните два кортежа.
                (int, string, char, string, ulong) tuple2 = (a: 4, b: "Tom", c: 'a', d: "string", e: 56);

                if (tuple.Equals(tuple2))
                {
                    Console.WriteLine("Кортежи равны!");
                }

                // 5) Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых и строка. 
                //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива,
                //сумму элементов массива и первую букву строки.
                (int, int, char) myFunction(int[] arrayOfInt, string string1)
                {
                    (int, int, char) tuple3 = (arrayOfInt.Min(), arrayOfInt.Max(), string1.First());

                    return tuple3;
                }

                myFunction(array, str5);


                Console.ReadKey();
            }
        }
    
}

