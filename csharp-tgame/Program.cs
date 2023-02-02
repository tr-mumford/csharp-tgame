using System.Threading;
using System.Windows.Input;

namespace csharp_tgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var countP = 0;
            var countE = 26;

            while (true)
            {
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

                //var testString = Console.ReadKey(true).KeyChar;
                //if (testString == 'j') { countP--; }
                //if (testString == 'k') { countP++; }
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

                Thread.Sleep(500);
            }
        }
    }
}
