using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class building
    {
        string type;
        string capacity;
        string dimention;
        string dateOfCompletion;
    
        public building(string type, string capacity, string dimention, string dateOfCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimention = dimention;
            this.dateOfCompletion = dateOfCompletion;
        }

        public void showdata()
        {
            Console.WriteLine($"Type of building: {type} \nCapacity of building: {capacity} \nDimension of building: {dimention} " +
                $"\nDate of completion: {dateOfCompletion}");
        }

        static void Main()
        {
            building b = new building("Flat", "3BHK", "10", "15-sept-2022");
            b.showdata();
        }
    }
}
