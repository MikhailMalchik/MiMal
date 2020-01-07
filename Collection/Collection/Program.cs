using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание номер 1
            int p = 0;
            Student Misha = new Student(19, "Mikhail");
            ArrayList array = new ArrayList() {1,3,"string",9 };
            array.Add("пример");
            array.Add(Misha);
            array.Remove(Misha);
            Console.WriteLine("Введите обьект для поиска");
            object o = Console.ReadLine();
            foreach (object s in array)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(array.Capacity);
            foreach (object t in array)
            {
                if (o == t)
                {
                    Console.WriteLine("Результат поиска: ", o);
                    Console.WriteLine("Его индекс: ",array.IndexOf(t));
                }
            }
            //Задание номер 2
            LinkedList<char> task2 = new LinkedList<char>();
            task2.AddFirst('a');
            task2.AddFirst('b');
            task2.AddLast('c');
            task2.AddLast('d');
            foreach(char i in task2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Введите число удаляемых элементов");
            int f = int.Parse(Console.ReadLine());
            for(int k = 1; k<=f ;k++)
            {
                task2.RemoveFirst();
            }
            task2.AddAfter(task2.Last, 'k');
            task2.AddBefore(task2.Last, 'x');
            HashSet<char> task3 = new HashSet<char>();
            task3.Add('a');
            task3.Add('b');
            task3.Add('c');
            task3.Add('d');
            task3.Add('k');
            task3.Add('x');
            Console.WriteLine("Введите обьект для поиска");
            object ob = Console.ReadLine();
            foreach (object t in task3)
            {
                if (ob == t)
                {
                    Console.WriteLine("Результат поиска: ", o);
                }
            }
            foreach (char try1 in task3)
            {
                Console.WriteLine(try1);
            }
            //Задание номер 3
            LinkedList<Flowers> task4 = new LinkedList<Flowers>();
            Flowers fl1 = new Flowers("aaa","fff",44,"fffg");
            Flowers fl2 = new Flowers("bbb", "ggg", 55, "gggh");
            Flowers fl3 = new Flowers("ccc", "hhh", 66, "hhhi");
            Flowers fl4 = new Flowers("ddd", "iii", 77, "iiij");
            task4.AddFirst(fl1);
            task4.AddFirst(fl2);
            task4.AddLast(fl3);
            task4.AddLast(fl4);
            foreach (Flowers i in task4)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("Введите число удаляемых элементов");
            int fff = int.Parse(Console.ReadLine());
            for (int k = 1; k <= fff; k++)
            {
                task4.RemoveFirst();
            }
            HashSet<Flowers> task5 = new HashSet<Flowers>();
            task5.Add(fl1);
            task5.Add(fl2);
            task5.Add(fl3);
            task5.Add(fl4);
            Console.WriteLine("Введите обьект для поиска");
            object obk = Console.ReadLine();
            foreach (object t in task5)
            {
                if (obk == t)
                {
                    Console.WriteLine("Результат поиска: ", o);
                }
            }
            foreach (Flowers try2 in task5)
            {
                Console.WriteLine(try2.Name);
            }
        }
        private static void Product_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Flowers newUser = e.NewItems[0] as Flowers;
                    Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Flowers oldUser = e.OldItems[0] as Flowers;
                    Console.WriteLine($"Удален объект: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Flowers replacedUser = e.OldItems[0] as Flowers;
                    Flowers replacingUser = e.NewItems[0] as Flowers;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }
    }
}
