using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string – "add", "multiply", "subtract", "divid
            string command = Console.ReadLine().ToLower();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    PrintAdding(n1, n2);
                    break;
                case "multiply":
                    PrintMultiplying(n1, n2);
                    break;
                case "subtract":
                    PrintSubstracting(n1, n2);
                    break;
                case "divide":
                    PrintDividing(n1, n2);
                    break;

            }
        }

        private static void PrintDividing(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }

        static void PrintSubstracting(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        private static void PrintMultiplying(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        static void PrintAdding(int n1, int n2)
        {
            {
                Console.WriteLine(n1 + n2);
            }
        }
    }
}
