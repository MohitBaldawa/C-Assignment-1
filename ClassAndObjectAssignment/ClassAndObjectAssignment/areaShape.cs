using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class areaShape
    {
        void area(float x)
        {
            Console.WriteLine("the area of the square is " + (x * x) + " sq units");
        }
        void area(float x, float y)
        {
            Console.WriteLine("the area of the rectangle is " + x * y + " sq units");
        }
        void area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle is " + z + " sq units");
        }
        static void Main(string[] args)
        {

            areaShape obj = new areaShape();
            obj.area(5);
            obj.area(6, 7);
            obj.area(9.0);
          
        }
    }
}
