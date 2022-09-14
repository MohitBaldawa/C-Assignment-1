using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class bankAccount
    {
        //class-variables
        public int accountNo;
        public string DepositorName;
        public string typeOfAccount;
        public int balance;

        public void getValues()
        {
            Console.WriteLine("Enter the account number: ");
            accountNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of depositor: ");
           DepositorName = Console.ReadLine();

            Console.WriteLine("Enter the type of account: ");
            typeOfAccount = Console.ReadLine();

            Console.WriteLine("Enter the balance: ");
            balance = int.Parse(Console.ReadLine());
        }

        public void deposit()
        {
            Console.WriteLine("Enter the amount to deposit: ");
            int deposit = int.Parse(Console.ReadLine());
            balance = balance + deposit;
            Console.WriteLine("Your balance is: "+balance);
        }

        public void withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw: ");
            int withdraw = int.Parse(Console.ReadLine());
            balance = balance + withdraw;
            Console.WriteLine("Your balance is: " + balance);
        }

        public void displayDetails()
        {
            Console.WriteLine("Name: "+DepositorName);
            Console.WriteLine("Balance: " + balance);

        }

        static void Main()
        {
            bankAccount b = new bankAccount();

            b.getValues();
            b.deposit();
            b.withdraw();
            b.displayDetails();
        }

    }
}
