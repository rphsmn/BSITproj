using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string direction, sw, door;
            Console.WriteLine("Welcome to Treasure Island.\nYour mission is to find the treasure.");

            Console.Write("Go left or right?: ");
            direction = Console.ReadLine();
            if (direction == "left")
            {
                Console.Write("swim or wait?: ");
                sw = Console.ReadLine();

                if (sw == "swim")
                {
                    Console.Write("Which door? (red/blue/yellow): ");
                    door = Console.ReadLine();

                    if (door == "yellow")
                    {
                        Console.WriteLine("You Win!");
                    }
                    else if (door == "red")
                    {
                        Console.WriteLine("Burned by fire. Game over.");
                    }
                    else if (door == "blue")
                    {
                        Console.WriteLine("Eaten by beast. Game over.");
                    }
                    else
                    {
                        Console.WriteLine("Born losers. Game over.");
                    }
                }
                else
                {
                    Console.Write("Attack by trout!");
                }
            }
            else
            {
                Console.Write("Fall into a hole. Game over.");
            }
        }
    }
}
