using System.Runtime.InteropServices;

namespace Topic___5_programming_Assignment___Worst_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int winNum;
            Console.WriteLine("welcome to the worst guessing game!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to contunue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("you will be guessing a number from 1 to 10");
            Console.WriteLine("Press Enter to contunue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("READY?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("SET!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("GUESS!!!");
            Console.WriteLine("Number: ");
            int.TryParse(Console.ReadLine(), out winNum);
            if (winNum > 10 || winNum < 1)
            {
                Console.WriteLine("NOPE! Remember its from 1 to 10");
                Console.WriteLine("Better luck next time");
            }
            else if (winNum == 7) 
            {
                Console.WriteLine("CORRECT! YOU WON!!!");
            }
            else
            {
                Console.WriteLine("Wrong number. the correct number was 7");
            }
        }
    }
}
