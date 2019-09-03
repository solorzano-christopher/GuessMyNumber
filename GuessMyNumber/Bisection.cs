using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    class Bisection
    {
        public static int TryBisection(int[] array, int Input)
        {
            int left = 0;
            int right = array.Length; // 10
            int middle;

            do //While 0 <= 10.
            {
                middle = left + (right - left) / 2; // 10 + (10 - 0) /2 = 5.1
                Console.WriteLine($"The middle is now {middle}");
                if (middle > Input)
                {
                    Console.WriteLine("User Input is lower than the middle");
                    right = middle - 1; Console.WriteLine($"The right will now be the {middle}  +1");
                }
                else if (middle < Input)
                {
                    Console.WriteLine("User Input is higher than the middle");
                    left = middle + 1; Console.WriteLine($"The left is now {middle} - 1");
                }
            } while (middle != Input);
            Console.WriteLine($"User number is {middle}! \n\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();
            return middle;
        }
    }
}
