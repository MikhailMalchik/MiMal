using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
namespace _14lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1 -------------------------------------------------------------
            Flowers fl1 = new Flowers("vasilki", "Very beautiful", 1000, "fff");
            Flowers fl2 = new Flowers("Rose", "beautiful", 2000, "ddd");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Flowers.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, fl1);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("Flowers.dat", FileMode.OpenOrCreate))
            {
                Flowers newfl = (Flowers)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newfl.Name} --- Цена: {newfl.Cost}");
            }
            //Soap
            SoapFormatter formatter1 = new SoapFormatter();
            using (FileStream fs = new FileStream("Flowers1.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, fl1);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("Flowers1.dat", FileMode.OpenOrCreate))
            {
                Flowers newfl = (Flowers)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newfl.Name} --- Цена: {newfl.Cost}");
            }
            //json
            string json = JsonConvert.SerializeObject(fl1);
            Console.WriteLine(json);
            Flowers restoredFlower = JsonConvert.DeserializeObject<Flowers>(json);
            Console.WriteLine(restoredFlower.Name);
            //xml
            XmlSerializer formatterx = new XmlSerializer(typeof(Flowers));
            using (FileStream fs = new FileStream("Flowers1.xml", FileMode.OpenOrCreate))
            {
                formatterx.Serialize(fs, fl1);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("Flowers1.xml", FileMode.OpenOrCreate))
            {
                Flowers newFlower = (Flowers)formatterx.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newFlower.Name} --- Цена: {newFlower.Cost}");
            }
            Console.ReadLine();
            //2 задача-----------------------------------------------------------------
            Flowers[] flowers = new Flowers[] { fl1, fl2 };
            BinaryFormatter formatter2 = new BinaryFormatter();
            using (FileStream fs = new FileStream("Flowers2.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, flowers);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("Flowers2.dat", FileMode.OpenOrCreate))
            {
                Flowers[] newfl = (Flowers[])formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                foreach(Flowers p in newfl)
                {
                    Console.WriteLine($"Имя: {p.Name} --- Цена: {p.Cost}");
                }
            }
            //Soap
            SoapFormatter formatter3 = new SoapFormatter();
            using (FileStream fs = new FileStream("Flowers3.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, flowers);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("Flowers3.dat", FileMode.OpenOrCreate))
            {
                Flowers[] newfl = (Flowers[])formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                foreach (Flowers p in newfl)
                {
                    Console.WriteLine($"Имя: {p.Name} --- Цена: {p.Cost}");
                }
            }
            //json
            string json1 = JsonConvert.SerializeObject(flowers);
            Console.WriteLine(json);
            Flowers[] restoredFlower1 = JsonConvert.DeserializeObject<Flowers[]>(json1);
            Console.WriteLine(restoredFlower.Name);
            //xml
            XmlSerializer formatterx1 = new XmlSerializer(typeof(Flowers[]));
            using (FileStream fs = new FileStream("Flowers2.xml", FileMode.OpenOrCreate))
            {
                formatterx1.Serialize(fs, flowers);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("Flowers2.xml", FileMode.OpenOrCreate))
            {
                Flowers[] newFlower = (Flowers[])formatterx1.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                foreach (Flowers p in newFlower)
                {
                    Console.WriteLine($"Имя: {p.Name} --- Цена: {p.Cost}");
                }
            }
            Console.ReadLine();
            //3 задание---------------------------------------------------------------------------------
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D://Xpath1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);
            XmlNodeList childnodes1 = xRoot.SelectNodes("flower");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.SelectSingleNode("@name").Value);
            Console.ReadLine();
            //4 задание
            XDocument xDocument = new XDocument(new XElement("Flows",
                new XElement("flower",
                         new XElement("flower", fl1.Name),
                         new XElement("Cost", fl1.Cost)),
                new XElement("flower",
                         new XElement("flower", fl2.Name),
                         new XElement("Cost", fl2.Cost))));
            xDocument.Save("Flower.xml");
            Console.ReadLine();
        }
    }
}
