using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            
            int quantity=int.Parse(Console.ReadLine());
            CalculatePriceOfAnOrder(product, quantity);
        }
        static void CalculatePriceOfAnOrder(string product, int quantity)
        {
            product= product.ToLower();
            double price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.5 * quantity;
                    break;
                case "water":
                    price = quantity * 1.0;
                    break;
                case "coke":
                    price = quantity * 1.4;
                    break;
                case "snacks":
                    price = quantity * 2.0;
                    break;

                default:
                    break;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
