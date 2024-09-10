using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bill = 0;




            Console.WriteLine("Welcome to Python Pizza Deliveries!");

            Console.Write("What size do you want? S, M, or L: ");
            string size = Console.ReadLine();


            Console.Write("Do you want pepperoni on your pizza? Y or N: ");
            string pep = Console.ReadLine();

            Console.Write("Do you want extra cheese? Y or N: ");
            string cheese = Console.ReadLine();

            //pizza size pricing

            if (size.ToUpper() == "S")
            {
                bill += 15;
            }
            else if (size.ToUpper() == "M")
            {
                bill += 20;
            }
            else
            {
                bill += 25;
            }



            //compute total bill


            if (pep.ToUpper() == "Y")
            {
                bill += 2;
            }

            if (cheese.ToUpper() == "Y")
            {
                bill += 1;
            }


            Console.Write($"Your final bill is: {bill}");
            bill = int.Parse(Console.ReadLine());
 
        }
    }
}
