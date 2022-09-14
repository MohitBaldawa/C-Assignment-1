using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class EvenOddCount
    {
        static void Main()
        {
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("How many numbers you want to enter: ");
            int totalNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers: ");
            int[] numbers = new int[totalNumber];

            for (int i = 0; i < totalNumber; i++)
            { 
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if(numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Total number of even count is "+evenCount +"\nTotal number of odd count is "+oddCount);
        }
    }
}
