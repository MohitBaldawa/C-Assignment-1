using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class studentMark
    {
        private string StudentName;
        private int RollNo;
        private double MarksEng, MarksMath, MarksSci;



        public void Student(string s, int r, double e, double m, double c)
        {
            this.StudentName = s;
            this.RollNo = r;
            this.MarksEng = e;
            this.MarksMath = m;
            this.MarksSci = c;
        }



        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int r = Convert.ToInt32(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            studentMark student = new studentMark();
            student.Student(s, r, e, m, c);

            double total = student.MarksMath + student.MarksSci + student.MarksEng;
            double percentage = total / 3.0;

            Console.WriteLine("total" + total);
            Console.WriteLine("percentage" + percentage);
        }
    }
}
