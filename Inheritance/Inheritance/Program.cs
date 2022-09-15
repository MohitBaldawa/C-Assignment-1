using System.Diagnostics;

namespace Inheritance
{
    internal class Program
    {
        class furniture
        {
            public int orderId;
            public string orderDate;
            public string furnitureType;
            public int qty;
            public int totalAmount;
            public string paymentMode;
    
        }

        class Chair : furniture
        {
            public string chairType;
            public string purpose;
            public string type;
            public int rate;

          

            public void GetData()
            {

                Console.WriteLine("Enter the chair type: ");
                chairType = Console.ReadLine();

                Console.WriteLine("Enter the purpose: ");
                purpose = Console.ReadLine();

                Console.WriteLine("Enter the type: ");
                type = Console.ReadLine();

                Console.WriteLine("rate: ");
                rate = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the quantity: ");
                qty = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the payment: ");
                paymentMode = Console.ReadLine();

                totalAmount = qty * rate;

            }
            public void ShowData()
            {
                Console.WriteLine("Order id: " + orderId);
                Console.WriteLine("Order Date: " + orderDate);
                Console.WriteLine("Furniture type: " + furnitureType);
                Console.WriteLine("Chair type: "+chairType);
                Console.WriteLine("Purpose: "+purpose);
                Console.WriteLine("type: "+type);
                Console.WriteLine("Quantity: " + qty);
                Console.WriteLine("Payment Mode: " + paymentMode);
                Console.WriteLine("Total Amount:" + totalAmount);
            }
        }

        class cot : furniture
        {
            public string cotType;
            public string type;
            public string capacity;
            public int rate;

            

            public void GetData()
            {

                Console.WriteLine("Enter the cot type: ");
                cotType = Console.ReadLine();

                Console.WriteLine("Enter the type: ");
                type = Console.ReadLine();

                Console.WriteLine("Enter the capacity: ");
                capacity = Console.ReadLine();

                Console.WriteLine("rate: ");
                rate = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the quantity: ");
                qty = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the payment: ");
                paymentMode = Console.ReadLine();

                totalAmount = qty * rate;

            }
            public void ShowData()
            {
                Console.WriteLine("Order id: " + orderId);
                Console.WriteLine("Order Date: " + orderDate);
                Console.WriteLine("Furniture type: " + furnitureType);
                Console.WriteLine("Cot type: " + cotType);
                Console.WriteLine("Capacity: " + capacity);
                Console.WriteLine("type: " + type);
                Console.WriteLine("Quantity: " + qty);
                Console.WriteLine("Payment Mode: " + paymentMode);
                Console.WriteLine("Total Amount:" + totalAmount);
            }
        }

        static void Main(string[] args)
        {
            
            furniture f = new furniture();

            f.orderId = 123;
            f.orderDate = "15-sept-2022";
            f.furnitureType = "chair";
            Chair c = new Chair();
            c.GetData();
            c.ShowData();

        }
    }
}