using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static Текстовый_Конвертер228.SaveFile;

namespace Текстовый_Конвертер228
{
    public static class SaveFile
    {
        public static void ReadFile(List<Igrushky> TeddyBear)
        {
            string FileName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сохранить файл в одном из трех форматов(txt,json,xml) - F1. Выйти из программы - Escape");
            Console.WriteLine("---------------------------------------");
            if (File.Exists(FileName))
            {
                foreach (Igrushky item in TeddyBear)
                {
                    Console.WriteLine($"{item.Name}\n{item.kolichestvo}\n{item.vid}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ошибка ввода");
                Program.Main();
            }
            ConsoleKey key;
            key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.F1:
                    string xzchto = Desearelizatsia.ToText(FileName);
                    Console.Clear();
                    Console.WriteLine("Введите путь до файла(вместе с названием),куда вы хотите сохранить текст");
                    Console.WriteLine("------------------------------------------------------------------------");
                    string str = Console.ReadLine();
                    if (str.Contains("json"))
                    {
                        Desearelizatsia.ToJson(str);
                    }
                    if (str.Contains("xml"))
                    {
                        Desearelizatsia.ToXml(str);
                    }
                    if (str.Contains("txt"))
                    {
                        File.WriteAllText(str, Desearelizatsia.ToText(xzchto));
                    }
                    Console.WriteLine("Успешно сохранено! Спасибо что воспользовались текстовым редактором!");
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    return;
            }

        }
        public class Desearelizatsia
        {
            internal static string ToText(string abc)
            {
                List<Igrushky> Figyra = new List<Igrushky>();
                string str = abc.Split(".")[^1];
                if (str == "json")
                {
                    Figyra = JsonConvert.DeserializeObject<List<Igrushky>>(File.ReadAllText(abc));
                }
                if (str == "xml")
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Igrushky>));
                    using (FileStream fs = new FileStream(abc, FileMode.Open))
                    {
                        Figyra = (List<Igrushky>)xml.Deserialize(fs);
                    }
                }
                else
                {
                    Figyra = ToList(str);
                }
                string result = null;
                foreach (Igrushky item in Figyra)
                {
                    result += $"{item.Name}\n{item.kolichestvo}\n{item.vid}\n";
                }
                return result;
            }
            private static List<Igrushky> ToList(string text)
            {
                List<Igrushky> positions = new List<Igrushky>();
                Igrushky kukla = new Igrushky();
                kukla.Name = "Кукла";
                kukla.kolichestvo = 10;
                kukla.vid = "фарфоровые";
                Igrushky myshka = new Igrushky();
                myshka.Name = "Мишка";
                myshka.kolichestvo = 6;
                myshka.vid = "Плюшевые";
                Igrushky mashynki = new Igrushky();
                mashynki.Name = "Машинка";
                mashynki.kolichestvo = 74;
                mashynki.vid = "Пластмасовые";
                List<Igrushky> list = new List<Igrushky>();
                positions.Add(kukla);
                positions.Add(myshka);
                positions.Add(mashynki);
                return positions;
            }
            internal static void ToJson(string str)
            {
                List<Igrushky> Figyra = ToList(str);
                string sJSONResponse = JsonConvert.SerializeObject(Figyra);
                File.WriteAllText(str, sJSONResponse);

            }
            internal static void ToXml(string str)
            {
                List<Igrushky> Figyra = ToList(str);
                XmlSerializer xml = new XmlSerializer(typeof(List<Igrushky>));
                using var stream = File.OpenWrite(str);
                xml.Serialize(stream, Figyra);
            }
        }
    }
}
