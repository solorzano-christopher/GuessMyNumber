using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    public class Program 
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("\n\tGuessMyNumber.Program.Main");
                Console.WriteLine("Demostrating bisection. Enter a number from 1-10");
                int[] list = { 1, 2, 2, 4, 5, 6, 7, 8, 9, 10 };
                int UserInput = Convert.ToInt32(Console.ReadLine());
                while (UserInput > 10)
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid input! Please, try again.");
                    Console.WriteLine("Enter a number from 1-10");
                    UserInput = Convert.ToInt32(Console.ReadLine());
                }
                int x = Bisection.TryBisection(list, UserInput);
                Console.WriteLine("Now let's test your skill.");
                int UserGame = UserPlays.TheUserPlays();
                Console.WriteLine("Now let's test the computer's skill");
                int ComputerGame = ComputerPlays.TheComputerPlays();
                Console.WriteLine($"\nIt took you {UserGame} times to guess the number the computer took {ComputerGame}.");
                if (UserGame > ComputerGame)
                {
                    Console.WriteLine("\nLooks like the Computer did better than you! :(");
                }
                else if (ComputerGame < UserGame)
                {
                    Console.WriteLine("\nCongrats you did better than the computer! :)");
                }
                else if(ComputerGame == UserGame)
                {
                    Console.WriteLine("\nWell, looks like you both took the same amount of times.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Main();
            }
        }
    }
}
