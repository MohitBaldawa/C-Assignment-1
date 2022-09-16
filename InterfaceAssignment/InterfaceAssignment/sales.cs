using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    abstract class monthly
    {
        public abstract int MonthlySales(int dailySale);
        public int dailySales(int dailySale)
        {
            return dailySale;

        }

    }
    interface anualSale
    {
        int yearlySales(int dailySale);
    }
     class sales : monthly,anualSale
    {
        public override int MonthlySales(int dailySale)
        {
            return dailySale * 30;
        }
       
        public int yearlySales(int dailySale)
        {
            return (dailySale * 30) * 12;
        }

        static void Main(string[] args)
        {
            sales s = new sales();  // Create a Pig object
            Console.WriteLine("Daily Sales: "+s.dailySales(400));
            Console.WriteLine("Monthly Sale: "+s.MonthlySales(400));
            Console.WriteLine("Yearly Sale: " + s.yearlySales(400));

        }

    }

}
