using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    public class ComputerPlays
    {
        public static int TheComputerPlays()
        {
            int right = 100;
            int left = 1;
            int middle; 
            Random random = new Random();
            int ComputerNum = random.Next(1, 100);
            int Response;
            int NumOfGuesses = 0;

            Console.WriteLine("Please choose a number between 1 - 100.");
            int UserNum = Convert.ToInt32(Console.ReadLine()); 
            do 
            {
                Console.Clear();
                Console.WriteLine($"Your number is {UserNum}.");
                Console.WriteLine($"Computer guessed {ComputerNum}. Is this your number? Enter 1, 2, or 3. \n\t1. Number is too high. \n\t2. Number is too low.\n\t3. Correct!");
                Response = Convert.ToInt32(Console.ReadLine());
                middle = left + (right - left) / 2; 
                if (Response == 1)
                {
                    Console.WriteLine("Computer's guess is higher than the UserNum");
                    right = ComputerNum - 1; 
                    ComputerNum = random.Next(left, right);
                    NumOfGuesses++;
                }
                else if (Response == 2)
                {
                    Console.WriteLine("Computer's guess is lower the UserNum");
                    left = ComputerNum + 1; 
                    ComputerNum = random.Next(left, right);
                    NumOfGuesses++;
                }
                else if (Response != 1 && Response != 2 && Response != 3)
                {
                    //Will Restart the loop since the user response was inserted incorrectly.
                }
            } while (Response != 3);
            Console.WriteLine($"The Computer took {NumOfGuesses} times to guess your number.");
            Console.WriteLine("\nPress any key to continue . . . ");
            Console.ReadKey();
            return NumOfGuesses;
        }
        
    }
}
