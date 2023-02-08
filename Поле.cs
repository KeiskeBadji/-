using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace змейка
{
    internal class Поле
    {
        enum EActiv
        {
            STOP = 0, LEFT, RIGHT, UP, DOWN
        }
        static int[] tailX = new int[360];
        static int[] tailY = new int[360];
        static int ntail;
        static bool gameOver;
        const int width = 20;
        const int height = 20;
        static int x, y, fruitX, fruitY;
        static int score;

        static EActiv dir;
        public void setup()
        {
            Random rand = new Random();
            int marvel = rand.Next();

            gameOver = false;
            dir = EActiv.STOP;
            x = width / 2;
            y = height / 2;
            fruitX = marvel % (width - 2);
            fruitY = marvel % (height - 2);
            score = 0;
        }
        static void draw()
        {
            Console.Clear();
            for (int i = 0; i <= width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("#");
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == (width - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("#");
                    }
                    if (i == y && j == x)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("0");
                    }
                    else if (i == fruitY && j == fruitX)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("@");
                    }
                    else
                    {
                        bool print = false;
                        for (int k = 0; k < ntail; k++)
                        {
                            if (tailX[k] == j && tailY[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("o");
                                print = true;
                            }
                        }
                        if (!print)
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("#");
            }
            Console.WriteLine();
            Console.WriteLine(score);
        }
        static void input()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey();
                switch (keyInfo.KeyChar)
                {
                    case 'a':
                        dir = EActiv.LEFT;
                        break;
                    case 'd':
                        dir = EActiv.RIGHT;
                        break;
                    case 'w':
                        dir = EActiv.UP;
                        break;
                    case 's':
                        dir = EActiv.DOWN;
                        break;
                    case 'x':
                        gameOver = true;
                        break;
                }
            }
        }
    }
}