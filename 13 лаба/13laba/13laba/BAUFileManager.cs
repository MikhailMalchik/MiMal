using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace _13laba
{
    public class BAUFileManager
    {
        public void Task()
        {
            string path = "D:\\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            string newdir = "XXXInspect";
            dirInfo.CreateSubdirectory(newdir);
            string filepath = "D:\\XXXInspect\\xxxdirinfo.txt";
            using (FileStream fs = File.Create(filepath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                fs.Write(info, 0, info.Length);
            }
            string newFilePath = "D:\\xxxnewdirinfo.txt";
            File.Copy(filepath, newFilePath, true);
            File.Delete(filepath);
            string onemorenewdir = "XXXFiles";
            dirInfo.CreateSubdirectory(onemorenewdir);
            string filetocopy = "D:\\param.txt";
            string full = "D:\\XXXFiles\\param.txt";
            FileInfo fileInf = new FileInfo(filetocopy);
            if (fileInf.Extension == ".txt")
            {
                fileInf.CopyTo(full, true);
            }
            string startPath = "D:\\XXXFiles";
            string zipPath = "D:\\result.zip";
            string extractPath = "D:\\extract";
            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);

        }
    }
}
