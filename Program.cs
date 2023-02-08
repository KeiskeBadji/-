using System.Diagnostics;
using System.Text.Json;

namespace SpeedTest
{
    public static class ScoreTable
    {
        public static void addToTable(string username, string scsec, string scmin)
        {
            string file = "table.json";
            if (File.Exists(file))
            {
                string tab = File.ReadAllText(file);
                List<UserScore> json = JsonSerializer.Deserialize<List<UserScore>>(tab);
                UserScore newuser = new UserScore(username, scmin, scsec);
                json.Add(newuser);

            }
            else
            {
                List<UserScore> lst = new List<UserScore>();
                UserScore user = new UserScore(username, scmin, scsec);
                lst.Add(user);
                string json = JsonSerializer.Serialize(lst);
                File.WriteAllText(file, json);
            }
        }
        public static void ShowTable()
        {
            string file = "table.json";
            string tab = File.ReadAllText(file);
            List<UserScore> json = JsonSerializer.Deserialize<List<UserScore>>(tab);
            Console.Clear();
            Console.WriteLine("Таблица: ");
            foreach (var u in json)
            {
                Console.WriteLine($"{u.username}    {u.scoremin}сим/мин    {u.scoresec}сим/сек");
            }

        }
    }

    public static class Timer
    {
        public static Stopwatch stopWatch = new Stopwatch();
        public static int sec = 0;
        public static bool cancel;

        public static void UpdateTimer()
        {
            stopWatch.Start();
            Console.SetCursorPosition(0, 10);
            Console.Write("Время:");
            cancel = false;

            while (stopWatch.Elapsed.Seconds != 59)
            {
                if (cancel)
                {
                    break;
                }

                sec += 1;
                Console.SetCursorPosition(7, 10);
                Console.Write("  ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{sec} сек.  ");

                Thread.Sleep(1000);
            }
            stopWatch.Stop();
        }
    }
    public static class SpeedWriteTest
    {
        private static UserScore user;
        public static string nickname;
        public static int inp_l;
        public static void init()
        {
            Console.WriteLine("Введите имя пользователя");
            nickname = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 2);
            int step = 0;
            int coord_x = 0;
            int coord_y = 2;
            inp_l = 0;
            int losep = 0;

            Console.ForegroundColor = ConsoleColor.Magenta;

            string v = "Происхождение Александра Сергеевича Пушкина идёт от разветвлённого нетитулованного дворянского рода Пушкиных, восходившего по генеалогической легенде к «мужу честну» Ратше" +
                       " Пушкин неоднократно писал о своей родословной в стихах и прозе; он видел в своих предках образец истинной «аристократии», древнего рода, честно служившего отечеству, но не снискавшего благосклонности правителей и «гонимого»." +
                       " Не раз он обращался (в том числе в художественной форме) и к образу своего прадеда по матери — африканца Абрама Петровича Ганнибала, ставшего слугой и воспитанником Петра I, а потом военным инженером и генералом." +
                       " В XVII веке предки Пушкина по отцу не поднимались выше придворного чина стольника. Прадед, живший в эпоху Петра I, Александр Петрович Пушкин, был сержантом гвардии и в 1725 году в припадке безумия убил свою жену; дед, Лев Александрович, был полковником артиллерии, капитаном гвардии." +
                       " Отец — Сергей Львович Пушкин (1770—1848), светский острослов и поэт-любитель.";
            List<char> lst = v.ToList();

            Console.WriteLine(string.Join("", lst));
            Thread tr = new Thread(_ =>
            {
                Timer.UpdateTimer();
            });
            tr.Start();
            bool lose = false;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (lose)
                {
                    if (coord_x + 1 > Console.BufferWidth)
                    {
                        coord_y++;
                        coord_x = 0;
                    }
                    else if (Timer.sec == 59)
                    {

                        ScoreTable.addToTable(nickname, $"{inp_l}", $"{inp_l / 60}");
                        ScoreTable.ShowTable();
                        break;
                    }
                    else if (inp_l + losep == lst.Count)
                    {
                        Console.Clear();
                        Timer.cancel = true;
                        ScoreTable.addToTable(nickname, $"{inp_l}", $"{inp_l / 60}");
                        ScoreTable.ShowTable();
                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(coord_x, coord_y);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(key.KeyChar);
                        losep++;
                        coord_x++;
                    }
                }
                else
                {
                    if (coord_x + 1 > Console.BufferWidth)
                    {
                        coord_y++;
                        coord_x = 0;
                    }
                    else if (key.KeyChar != lst[inp_l])
                    {
                        lose = true;
                    }
                    else if (inp_l == lst.Count)
                    {
                        Console.Clear();
                        Timer.cancel = true;
                        ScoreTable.addToTable(nickname, $"{inp_l}", $"{inp_l / 60}");
                        ScoreTable.ShowTable();
                        break;

                    }
                    else if (Timer.sec == 59)
                    {

                        ScoreTable.addToTable(nickname, $"{inp_l}", $"{inp_l / 60}");
                        ScoreTable.ShowTable();
                        break;
                    }


                    else
                    {
                        Console.SetCursorPosition(coord_x, coord_y);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(key.KeyChar);
                        inp_l++;
                        coord_x++;
                    }

                }

            }

        }
        public static void Main()
        {
            init();
        }
    }
}
