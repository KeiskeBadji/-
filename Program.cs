
namespace Текстовый_Конвертер228
{
    internal class Program
    { 
        public static void Main()
        {
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
            list.Add(new Igrushky() { Name = "Кукла", kolichestvo = 10, vid = "фарфоровые" });
            list.Add(new Igrushky() { Name = "Мишка", kolichestvo = 6, vid = "Плюшевые" });
            list.Add(new Igrushky() { Name = "Машинка", kolichestvo = 74, vid = "Пластмасовые" });
            Console.WriteLine("Введите путь до файла (вместе с названием), который вы хотите открыть");
            Console.WriteLine("-------------------------------------------------------------------------");
            SaveFile.ReadFile(list);
        }
    }
}