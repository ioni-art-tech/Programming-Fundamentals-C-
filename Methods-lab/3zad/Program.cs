using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintNewColumn(i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintNewColumn(i);
            }

        }

        private static void PrintNewColumn(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");

            }
            Console.WriteLine();
        }
    }
}
