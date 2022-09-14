using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class displayMarks
    {
        static void Main()
        {
            int total = 0, avg, min,max;
            Console.WriteLine("Enter the total 10 marks: ");
            int[] marks = new int[10];
            for (int i = 0; i < 10; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
                min = marks[0];
            max = marks[0];
            for (int i = 0; i < 10; i++)
            { 
          
                total = total + marks[i];

                if (min < marks[i + 1])
                    min = min;
                else
                    min = marks[i+1];

                if (max > marks[i + 1])
                    max = max;
                else
                    max = marks[i + 1];

            }
            avg = total /10;
            Console.WriteLine("Total of marks: "+total);
            Console.WriteLine("Average of marks: " +avg);
            Console.WriteLine("Minimum of marks: " +min);
            Console.WriteLine("Maximum of marks: " +max);


            
        }
    }
}
