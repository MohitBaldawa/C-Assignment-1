using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class temperature
    {
        static void Main() 
        {
            Console.WriteLine("Enter the temperature in fahrenheit: ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());

            float celceus = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine(fahrenheit +" fahrenheit to celsius is: "+celceus);
        }
       
    }
}
