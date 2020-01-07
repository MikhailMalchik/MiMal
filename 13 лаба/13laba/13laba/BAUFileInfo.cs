using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13laba
{
    public class BAUFileInfo
    {
        public void Info()
        {
            Console.WriteLine("Информация о файле:");
            string path = "D:\\1.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Полный путь: {0}", fileInf.DirectoryName);
                Console.WriteLine("Расширение: {0}", fileInf.Extension);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length + " байт");
            }
            Console.WriteLine();
        }
    }

}

