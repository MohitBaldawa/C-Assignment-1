using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class account
    {
        //class-variables
        public int studentId;
        public string studentName;
        public DateTime dob;
        public string std;
        //methods
        public void Show()
        {
            Console.WriteLine($"ID:{studentId} " +
                $"Name:{studentName} DOB:{dob} STD:{std}");
        }
        static void Main()
        {
            //create student object
            account s1 = new account();
            s1.studentId = 3432;
            s1.studentName = "Aniket";
            s1.dob = DateTime.Parse("12.2.2013");
            s1.std = "III";
            s1.Show();
        }
    }
}
