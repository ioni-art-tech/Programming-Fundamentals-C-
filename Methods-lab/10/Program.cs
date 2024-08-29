using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int sumEven = GetSumOfEvenDigits(input);
            int sumOdd=GetSumOfOddDigits(input);    
            int result=sumEven*sumOdd;

            Console.WriteLine(result);
        }

        static int GetSumOfOddDigits(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int currDigit = input % 10;
                input /= 10;
                if (currDigit % 2 != 0)
                {
                    sum += currDigit;
                }
            }
            return sum;
        }
        private static int GetSumOfEvenDigits(int input)
        {
            int sum = 0;
            while (input>0)
            {
                int currDigit = input % 10;
                input /= 10;
                if (currDigit%2==0)
                {
                    sum += currDigit;
                }
            }
            return sum;
        }
    }
}
