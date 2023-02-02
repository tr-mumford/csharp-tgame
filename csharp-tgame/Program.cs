using System.Threading;
using System.Windows.Input;

namespace csharp_tgame
{
    internal class Program
    {

        static volatile bool exit = false;


        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var countP = 0;
            var countE = 26;

            while (true)
            {
                char testString = 'z';
                Console.SetCursorPosition(2, 2);

                char[] land =
                {
                    '_', '_', '_', '_', '_', '_', '_', '_',
                    '_', '_', '_', '_', '_', '_', '_', '_',
                    '_', '_', '_', '_', '_', '_', '_', '_',
                    '_', '_', '_', '_', '_', '_', '_', '_',
                };

                land[countP] = 'X';
                land[countE] = '<';

                for (int i = 0; i < land.Length; i++)
                {
                    Console.Write(land[i]);
                }

                Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        while (Console.ReadKey(true).Key != ConsoleKey.K) ;
                        exit = true;
                    }
                });

                while (!exit)
                {
                    Console.WriteLine("Hello!");
                    Thread.Sleep(1000);
                }

                //char testString = Console.ReadKey(true).KeyChar;
                if (testString == 'j') { countP--; }
                if (testString == 'k') { countP++; }
                countE = countE - 2;

                if(countE == countP)
                {
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                    Console.WriteLine("DEATH");
                }

                Thread.Sleep(1000);
            }
        }

        /*public static async Task userInput()
        {
            char testString = Console.ReadKey(true).KeyChar;
        }*/
    }
}
