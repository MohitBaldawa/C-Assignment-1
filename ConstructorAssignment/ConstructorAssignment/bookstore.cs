using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class bookstore
    {
        //class-variables
        private int isbn;
        private string bookName;
        private string bookTitle;
        private string bookAuthor;
        private int quantityOfBook;
        private int bookPrice;
        public int totalPrice;


        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; } 
        }
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        public int QuantityOfBook
        {
            get { return quantityOfBook; }
            set { quantityOfBook = value; }
        }
        public int BookPrice
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }


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
            b1.Isbn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of book: ");
            b1.BookName = Console.ReadLine();

            Console.WriteLine("Enter the author of book: ");
            b1.BookAuthor = Console.ReadLine();

            Console.WriteLine("Enter the quantity of book: ");
            b1.QuantityOfBook = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity of book: ");
            b1.BookPrice = int.Parse(Console.ReadLine());

            b1.displayResult();

        }
    }
}
