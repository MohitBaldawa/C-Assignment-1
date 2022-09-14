using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class creditCardCompany
    {
        static void Main()
        {
            Console.WriteLine("Enter Balance ");
            double m = double.Parse(Console.ReadLine());
            int month = 1;
            Console.WriteLine("Enter Pay ");
            int n= int.Parse(Console.ReadLine());
            int k = n;
            while (n > 0)
            {
                m = m + (1.5 * m) / 100;
                m = m - n;
                if (m < 0)
                    break;
                Console.WriteLine("Remaining Balance: " +m+ " monthly payment: " + k);
                k = k+n;
            }

        }
	
    }
}
