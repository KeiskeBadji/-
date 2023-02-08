Console.WriteLine("Нажмите для выбора октавы от F1-F6");
ConsoleKeyInfo clavisha = Console.ReadKey();
ConsoleKeyInfo key = Console.ReadKey();

int[] massive_oktava1 = new int[] {38, 41, 43, 46, 49, 51};
int[] massive_oktava2 = new int[] {77, 82, 87, 92, 98, 103};
int[] massive_oktava3 = new int[] {155, 164, 174, 185, 196, 207};
int[] massive_oktava4 = new int[] {311, 329, 349, 370, 392, 415};
int[] massive_oktava5 = new int[] {622, 659, 698, 740, 784, 830};
int[] massive_oktava6 = new int[] {1245, 1319, 1397, 1480, 1568, 1661};
int active_oktava = 1;
while (key.Key != ConsoleKey.Escape)
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.F1)
    {
        active_oktava = 1;
        Console.WriteLine("1 октава");
    }
    if (key.Key == ConsoleKey.F2)
    {
        active_oktava = 2;
        Console.WriteLine("2 октава");
    }
    if (key.Key == ConsoleKey.F3)
    {
        active_oktava = 3;
        Console.WriteLine("3 октава");
    }
    if (key.Key == ConsoleKey.F4)
    {
        active_oktava = 4;
        Console.WriteLine("4 октава");
    }
    if (key.Key == ConsoleKey.F5)
    {
        active_oktava = 5;
        Console.WriteLine("5 октава");
    }
    if (key.Key == ConsoleKey.F6)
    {
        active_oktava = 6;
        Console.WriteLine("6 октава");
    }
    if ((key.Key == ConsoleKey.Q) && (active_oktava == 1))
    {
        Console.Beep(38, 300);
    }
    if ((key.Key == ConsoleKey.Q) && (active_oktava == 2))
    {
        Console.Beep(77, 300);
    }
    if ((key.Key == ConsoleKey.Q) && (active_oktava == 3))
    {
        Console.Beep(155, 300);
    }
    if ((key.Key == ConsoleKey.Q) && (active_oktava == 4))
    {
        Console.Beep(311, 300);
    }
    if ((key.Key == ConsoleKey.Q) && (active_oktava == 5))
    {
        Console.Beep(622, 300);
    }
    if ((key.Key == ConsoleKey.Q) && (active_oktava == 6))
    {
        Console.Beep(1245, 300);
    }
    if ((key.Key == ConsoleKey.W) && (active_oktava == 1))
    {
        Console.Beep(41, 300);
    }
    if ((key.Key == ConsoleKey.W) && (active_oktava == 2))
    {
        Console.Beep(82, 300);
    }
    if ((key.Key == ConsoleKey.W) && (active_oktava == 3))
    {
        Console.Beep(164, 300);
    }
    if ((key.Key == ConsoleKey.W) && (active_oktava == 4))
    {
        Console.Beep(329, 300);
    }
    if ((key.Key == ConsoleKey.W) && (active_oktava == 5))
    {
        Console.Beep(659, 300);
    }
    if ((key.Key == ConsoleKey.W) && (active_oktava == 6))
    {
        Console.Beep(1319, 300);
    }
    if ((key.Key == ConsoleKey.E) && (active_oktava == 1))
    {
        Console.Beep(43, 300);
    }
    if ((key.Key == ConsoleKey.E) && (active_oktava == 2))
    {
        Console.Beep(87, 300);
    }
    if ((key.Key == ConsoleKey.E) && (active_oktava == 3))
    {
        Console.Beep(174, 300);
    }
    if ((key.Key == ConsoleKey.E) && (active_oktava == 4))
    {
        Console.Beep(349, 300);
    }
    if ((key.Key == ConsoleKey.E) && (active_oktava == 5))
    {
        Console.Beep(698, 300);
    }
    if ((key.Key == ConsoleKey.E) && (active_oktava == 6))
    {
        Console.Beep(1397, 300);
    }
    if ((key.Key == ConsoleKey.R) && (active_oktava == 1))
    {
        Console.Beep(46, 300);
    }
    if ((key.Key == ConsoleKey.R) && (active_oktava == 2))
    {
        Console.Beep(92, 300);
    }
    if ((key.Key == ConsoleKey.R) && (active_oktava == 3))
    {
        Console.Beep(185, 300);
    }
    if ((key.Key == ConsoleKey.R) && (active_oktava == 4))
    {
        Console.Beep(370, 300);
    }
    if ((key.Key == ConsoleKey.R) && (active_oktava == 5))
    {
        Console.Beep(740, 300);
    }
    if ((key.Key == ConsoleKey.R) && (active_oktava == 6))
    {
        Console.Beep(1480, 300);
    }
    if ((key.Key == ConsoleKey.T) && (active_oktava == 1))
    {
        Console.Beep(49, 300);
    }
    if ((key.Key == ConsoleKey.T) && (active_oktava == 2))
    {
        Console.Beep(98, 300);
    }
    if ((key.Key == ConsoleKey.T) && (active_oktava == 3))
    {
        Console.Beep(196, 300);
    }
    if ((key.Key == ConsoleKey.T) && (active_oktava == 4))
    {
        Console.Beep(392, 300);
    }
    if ((key.Key == ConsoleKey.T) && (active_oktava == 5))
    {
        Console.Beep(792, 300);
    }
    if ((key.Key == ConsoleKey.T) && (active_oktava == 6))
    {
        Console.Beep(1568, 300);
    }
    if ((key.Key == ConsoleKey.Y) && (active_oktava == 1))
    {
        Console.Beep(51, 300);
    }
    if ((key.Key == ConsoleKey.Y) && (active_oktava == 2))
    {
        Console.Beep(103, 300);
    }
    if ((key.Key == ConsoleKey.Y) && (active_oktava == 3))
    {
        Console.Beep(207, 300);
    }
    if ((key.Key == ConsoleKey.Y) && (active_oktava == 4))
    {
        Console.Beep(415, 300);
    }
    if ((key.Key == ConsoleKey.Y) && (active_oktava == 5))
    {
        Console.Beep(830, 300);
    }
    if ((key.Key == ConsoleKey.Y) && (active_oktava == 6))
    {
        Console.Beep(1661, 300);
    }
    
}
