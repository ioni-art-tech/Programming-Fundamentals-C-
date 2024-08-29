using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnNewString(word, n));
        }

        static string ReturnNewString(string word, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += word;
               
            }
            return result;
        }

    }
}
