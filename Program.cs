using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int speed;
            int speedlimit = 5;
            int demeritpts = 0;

            Console.WriteLine("The speed limit is 5km/hr");

            Console.Write("What is the speed of the car in km/hr: ");
            speed = int.Parse(Console.ReadLine());

            if (speed >= speedlimit)
            {
                demeritpts = speed / speedlimit;

                if (demeritpts > 12)
                {
                    Console.WriteLine("License is suspended.");
                }
                else
                {
                    Console.WriteLine("Your number of demerit points is: " + demeritpts);
                }
            }
            else
            {
                Console.WriteLine("Speed is OK.");
            }
        }
    }
}



