using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1=int.Parse(Console.ReadLine());
            char command=char.Parse(Console.ReadLine());
            int n2=int.Parse(Console.ReadLine());

            double result = Calculate(n1, command, n2);
            Console.WriteLine(result);
        }

        static double Calculate(int n1, char command, int n2)
        {
            switch (command)
            {
                case '+':
                    return n1 + n2;
                    break;
                case '-':
                    return n1 - n2;
                    break;
                case'*':
                    return n1 * n2;
                    break;
                case '/':
                    return n1 / n2;
                    break;
                default:
                    return double.Parse("wrong input");
                    break;
            }
        }
    }
}
