namespace InterfaceAssignment
{
    internal class Program
    {
        interface govtRules
        {
            public void employeePF(double basicSalary);
            public void leaveDetails();
            public void gratuityAmount(float serviceCompleted, double basicSalary);
        }

        class TCS : govtRules
        {
            public int empid;
            public string name;
            public string dept;
            public string desg;
            public int basicSalary;

            public TCS(int empid, string name, string dept, string desg, int basicSalary)
            {
                Console.WriteLine("TCS Employee Details:");

                this.empid = empid;
                this.name = name;
                this.dept = dept;
                this.desg = desg;
                this.basicSalary = basicSalary;
            }

            public void employeePF(double basicSalary)
            {
                double PF = (basicSalary * 8.33) / 100;
                double pensionFund = (basicSalary * 3.67) / 100;
                
                Console.WriteLine("Employee contribution to PF is: "+PF+" and pension fund is: "+pensionFund);
            }
            public void leaveDetails()
            {
                Console.WriteLine("1 day of Casual Leave per month");
                Console.WriteLine("12 days of Sick Leave per year");
                Console.WriteLine("10 days of Previlage Leave per year");
            }
            public void gratuityAmount(float serviceCompleted, double basicSalary)
            {
                double gratuityAmount;
                if (serviceCompleted >= 20)
                    gratuityAmount = basicSalary/12 * 3;
                else if (serviceCompleted >= 10)
                    gratuityAmount = basicSalary/12 * 2;
                else if (serviceCompleted >= 5)
                    gratuityAmount = basicSalary/12;
                else 
                    gratuityAmount = 0;
                

                Console.WriteLine("Employee gratuity amount is "+ gratuityAmount);
            }

        }
        class Accenture : govtRules
        {
           public  int empid;
            public string name;
            public string dept;
            public string desg;
            public int basicSalary;

            public Accenture(int empid, string name, string dept, string desg, int basicSalary)
            {
                Console.WriteLine("\nAccenture Employee Details:");

                this.empid = empid;
                this.name = name;
                this.dept = dept;
                this.desg = desg;
                this.basicSalary = basicSalary;
            }

            public void employeePF(double basicSalary)
            {
                double PF = (basicSalary * 100) / 12;
                

                Console.WriteLine("Employee contribution to PF is: " + PF);
            }
            public void leaveDetails()
            {
                Console.WriteLine("2 day of Casual Leave per month");
                Console.WriteLine("5 days of Sick Leave per year");
                Console.WriteLine("5 days of Previlage Leave per year");
            }
            public void gratuityAmount(float serviceCompleted, double basicSalary)
            {
                Console.WriteLine("Employee gratuity amount is not applicable");
            }

        }



        static void Main(string[] args)
        {
            TCS t = new TCS(123, "Mohit", "IT", "sr. analyst", 650000);
            t.employeePF((double)650000);
            t.leaveDetails();
            t.gratuityAmount(12, (double)650000);

            Accenture a = new Accenture(123, "Tom", "KPO", "technologist", 850000);
            a.employeePF((double)6850000);
            a.leaveDetails();
            a.gratuityAmount(12, (double)850000);


        }
    }
}