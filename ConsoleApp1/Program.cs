using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            
            try
            {
                Console.Write("cost ");
                double cost = Convert.ToDouble(Console.ReadLine());
                Console.Write("Payment ");
                double payment = Convert.ToDouble(Console.ReadLine());

                double quarter = 0.25;
                double dime = 0.10;
                double nickel = 0.05;
                double penny = 0.01;
                double change = payment - cost;
                int quarters = (int)(change / quarter);
                double changeLeft1 = change - quarter * quarters;
                int dimes = (int)(changeLeft1 / dime);
                double changeLeft2 = changeLeft1 - dime * dimes;
                int nickels = (int)(changeLeft2 / nickel);
                double changeLeft3 = changeLeft2 - nickel * nickels;
                int pennies = Convert.ToInt32(changeLeft3 / penny);

                if (quarters > 0)
                {
                    Console.WriteLine("Quarters: " + quarters);
                }
                if (dimes > 0)
                {
                    Console.WriteLine("Dimes " + dimes);
                }
                if (nickels > 0)
                {
                    Console.WriteLine("Nickels " + nickels);
                }
                if (pennies > 0)
                {
                    Console.WriteLine("Pennies " + pennies);
                }
                if (cost == payment)
                {
                    Console.WriteLine("No change");
                }
                if (payment < cost)
                {
                    Console.WriteLine("Insufficient payment");
                }
            }
            catch
            {
                Console.WriteLine("Enter an integer");
            }
            Console.ReadLine();
        }
    }
}
