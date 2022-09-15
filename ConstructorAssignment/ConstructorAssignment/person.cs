using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class person
    {
        string firstName;
        string lastName;
        string emailAddress;
        DateTime dob;
    
        public person(string firstName, string lastName, string emailAddress, DateTime dob)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.dob = dob;
        }

        public void show()
        {
            Console.WriteLine($"First Name: {firstName} \nLast Name: {lastName} \nEmail Address: {emailAddress} \nDate of Birth: {dob}");
        }

        static void Main()
        {
            person p = new person("Mohit", "Baldawa", "mohitbaldawa@gmail.com", new DateTime(1998, 7, 25));
            p.show();
        }
    }
}
