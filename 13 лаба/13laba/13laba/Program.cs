using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13laba
{
    class Program
    {
        static void Main(string[] args)
        {
            BAUDiskInfo disk = new BAUDiskInfo();
            disk.Info();
            BAUDirInfo dir = new BAUDirInfo();
            dir.Info();
            BAUFileInfo file = new BAUFileInfo();
            file.Info();
            BAUFileManager manager = new BAUFileManager();
            manager.Task();
            
            
 








            Console.ReadLine();
        }
    }
}
