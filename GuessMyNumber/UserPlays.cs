using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    public class UserPlays
    {
        public static int TheUserPlays()
        {
            Random random = new Random();
            int ComputerNum = random.Next(1, 1000);
            int Response;
            int NumOfGuesses = 0;
            Console.WriteLine("The computer has selected a number from 1 - 1000!");
            do
            {
                Console.WriteLine("Enter your guess.");
                Response = Convert.ToInt32(Console.ReadLine());
                if (Response > ComputerNum)
                {
                    Console.WriteLine("Your guess was too high!");
                    NumOfGuesses++;
                }
                else if (Response < ComputerNum)
                {
                    Console.WriteLine("Your guess was too low!");
                    NumOfGuesses++;
                }
            } while (ComputerNum != Response);
            Console.WriteLine($"Congrats you got it! The computer choose {ComputerNum} It took you {NumOfGuesses} times to get the right answer.");
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();
            return NumOfGuesses;
        }

    }
}
