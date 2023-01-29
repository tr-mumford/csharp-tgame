using System.Threading;
using System.Windows.Input;

namespace csharp_tgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(2, 2);
            Console.CursorVisible = false;

            var countP = 0;
            var countE = 26;

            while (true)
            {
                char[] land =
                {
                    '_', '_', '_', '_', '_', '_', '_', '_',
                    '_', '_', '_', '_', '_', '_', '_', '_',
                    '_', '_', '_', '_', '_', '_', '_', '_',
                    '_', '_', '_', '_', '_', '_', '_', '_',
                };


                for (int i = 0; i < land.Length; i++)
                {
                    land[countP] = 'X';
                    land[countE] = '<';
                    Console.Write(land[i]);
                }

                Console.SetCursorPosition(2, 2);

                var testString = Console.ReadKey().KeyChar;
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
            }
        }
    }
}
