using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class shape
    {
        public void area(float x)
        {
            Console.WriteLine("the area of the square is " + Math.Pow(x, 2) + " sq units");
        }
       public void area(float x, float y)
        {
            Console.WriteLine("the area of the rectangle is " + x * y + " sq units");
        }
        public void area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle is " + z + " sq units");
        }
        public void area(int b, int h)
        {
            double z =   (b * h)/2;
            Console.WriteLine("the area of the triangle is " + z + " sq units");
        }
        static void Main()
        {
            shape s = new shape();

            s.area((float)7);
            s.area((float)8.0,(float)9.0);
            s.area((double)12);
            s.area(13,14);
        }
    }
}
