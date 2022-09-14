using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectAssignment
{
    internal class bookstore
    {
        //class-variables
        public int isbn;
        public string bookName;
        public string bookTitle;
        public string bookAuthor;
        public int quantityOfBook;
        public int bookPrice;
        public int totalPrice;
        

        //methods
        public void displayResult()
        {
            totalPrice = bookPrice * quantityOfBook;

            Console.WriteLine($"\nBook Name:{bookName} " +
                   $"\nBook Title:{bookTitle}" + $"\nBook Author:{bookAuthor}" + $"\nQuantity of Books:{quantityOfBook}" + $"\nPrice of Book:{bookPrice}" + $"\nTotal bill amount:{totalPrice}");

        }


        static void Main()
        {
            //create bookstore object
            bookstore b1 = new bookstore();

            Console.WriteLine("Enter the isbn of book: ");
            b1.isbn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of book: ");
            b1.bookName = Console.ReadLine();

            Console.WriteLine("Enter the author of book: ");
            b1.bookAuthor = Console.ReadLine();

            Console.WriteLine("Enter the quantity of book: ");
            b1.quantityOfBook = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity of book: ");
            b1.bookPrice = int.Parse(Console.ReadLine());

            b1.displayResult();

        }
    }
}
