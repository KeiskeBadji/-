Console.WriteLine();
int position = 1;
ConsoleKeyInfo clavisha = Console.ReadKey();
ConsoleKeyInfo key = Console.ReadKey();

string[] massiv_data1 = new string[] {"1. Сходить к стоматологу", "2. Список продуктов", "3. Список гостей"};
string[] massiv_data2 = new string[] { };
string[] massiv_data3 = new string[] { };
string[] massiv_data4 = new string[] { }; 
string[] massiv_data5 = new string[] { };
string[] massiv_data6 = new string[] { };
string[] massiv_data7 = new string[] { };
string[] massiv_data8 = new string[] { };
string[] massiv_data9 = new string[] { };
string[] massiv_data10 = new string[] { };
string[] opisanie_data1 = new string[] { "Приём у стоматолога в 17:40", "Купить: молоко \n кукурузу \n зубную пасту", "Придут: Маша \n Кикрилл \n Олег /n Кристина \n Настя \n Денис" }; 

int active_data = 1;
while(key.Key != ConsoleKey.Escape)
{
    key = Console.ReadKey();
    Console.Clear();
    
    if (active_data == 1 && key.Key != ConsoleKey.Enter)
    {
        Console.WriteLine("Выбрана дата: 14.10.2022");
        foreach (string item in massiv_data1)
        {
            Console.WriteLine("   " + item);
        }
    }
    if (active_data == 2)
    {
        Console.WriteLine("Выбрана дата: 15.10.2022");
    }
    if (active_data == 3)
    {
        Console.WriteLine("Выбрана дата: 16.10.2022");
    }
    if (active_data == 4)
    {
        Console.WriteLine("Выбрана дата: 17.10.2022");
    }
    if (active_data == 5)
    {
        Console.WriteLine("Выбрана дата: 18.10.2022");
    }
    if (active_data == 0)
    {
        Console.WriteLine("Выбрана дата: 13.10.2022");
    }
    if (active_data == -1)
    {
        Console.WriteLine("Выбрана дата: 12.10.2022");
    }
    if (active_data == -2)
    {
        Console.WriteLine("Выбрана дата: 11.10.2022");
    }
    if (active_data == -3)
    {
        Console.WriteLine("Выбрана дата: 10.10.2022");
    }if (active_data == -4)
    {
        Console.WriteLine("Выбрана дата: 09.10.2022");
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        active_data++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        active_data--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;

    }

    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");
    
    if(key.Key == ConsoleKey.Enter)
    { 
            Console.WriteLine(opisanie_data1[position-1]);
    }
    
}