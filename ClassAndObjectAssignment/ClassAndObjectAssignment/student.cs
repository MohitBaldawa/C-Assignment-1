using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class student
    {
        //class-variables
        public int rollno;
        public string studentName;
        public string studentClass;
        public string studentBranch;
        public string result;
       public int[] marks = new int[5];
      
        //methods
        public void displayResult()
        {
            int total = 0;
            bool lessMark = false;
            for (int i = 0; i < 5; i++)
            {
                total = total + marks[i];
                if (marks[i] < 35)
                   lessMark = true;
            }
            int avg = total / 5;
            
            if (lessMark == true)
            {
                result = "Failed";
            }
            else {
                if (avg < 50)
                    result = "Failed";
                else
                    result = "Pass";
            }
  
        }

        public void displayData() {
            Console.WriteLine($"RollNo:{rollno} " +
                    $"\nName:{studentName}"+ $"\nClass:{studentClass}"+ $"\nBranch:{studentBranch}"+ $"\nResult:{result}");
        }
        static void Main()
        {
            //create student object
            student s1 = new student();
            s1.rollno = 3432;
            s1.studentName = "Aniket";
            s1.studentClass = "MCA";
                s1.studentBranch = "computer";
            Console.WriteLine("Enter the marks in 5 subject: ");
            for (int i = 0; i < 5; i++)
            {
                s1.marks[i] = int.Parse(Console.ReadLine());
            }

            s1.displayResult();
            s1.displayData();
        }
    }
}
