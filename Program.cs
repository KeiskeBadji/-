Console.WriteLine("Выберите игру: ");
/*ConsoleKeyInfo key = Console.ReadKey();*/

Console.WriteLine("1. Угадай число");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывод делителей числа");
Console.WriteLine("4. Закрыть программу");

int b = Convert.ToInt32(Console.ReadLine());
if (b == 1)
{
    Random rand = new Random();
    int i = rand.Next(10);
    int count = 1;
    Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгодать его за три попытки.");
    Console.WriteLine("Введите первое число:");
    int k = Convert.ToInt32(Console.ReadLine());
    while (count <= 3)
    {
        if (i == k)
        {
            Console.WriteLine("Да! Компьютер загадал число " + k + "!");
            break;
        }
        else
        {
            count++;
            if (count == 4)
            {
                Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                break;
            }
            Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
            k = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.ReadLine();
}
if (b == 2)
{
    Console.WriteLine("    |   1\t2\t3\t4\t5\t6\t7\t8\t9");
    Console.Write("--------------------------------------------------------------------------");
    Console.WriteLine();
    for (int i = 1; i < 10; i++)
    {
        Console.Write(i + "   |  ");
        for (int j = 1; j < 10; j++)
        {
            Console.Write("\t" + i * j);
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }
    Console.ReadLine();
}
if (b == 3)
{     
    Console.Write("Введи число ");
    int i = int.Parse(Console.ReadLine());
    for (int a = 1; a <= i; a++)
    {
        if (i % a == 0) Console.Write("{0} ", a);
    }
}
if (b == 4)
{
    Console.WriteLine();
}