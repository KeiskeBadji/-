using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace змейка
{
    internal class Выбор_режима
    {
        public void Main(string[] args)
        {
            int q;
            do
            {

                Console.WriteLine("1-свободный режим\n2-аркада\n3-выход");
                q = Int32.Parse(Console.ReadLine());
                Console.Clear();

                if (q == 1 || q == 2)
                {
                    setup();
                    while (!gameOver)
                    {
                        draw();
                        input();
                        logicOfGame(q);
                        Thread.Sleep(350);
                        if ((q == 1 || q == 2) && score == 3600)
                        {
                            Console.WriteLine("you won!");
                        }
                    }

                }
            } while (q == '3');
        }
}
