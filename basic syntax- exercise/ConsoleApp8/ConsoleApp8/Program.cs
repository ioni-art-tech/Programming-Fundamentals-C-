using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int? prSum = null;
            int? maxDiff = int.MinValue;

            int[] arr = new int[2 * n];
            bool areIdentical = true;
            for (int i = 0; i < 2 * n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 2 * n; i++)
            {
                int num1, num2;
                if (i % 2 != 0)
                {
                    num1 = arr[i - 1];
                    num2 = arr[i];
                    sum = num1 + num2;

                    if (prSum == null)
                    {
                        prSum = sum;
                    }
                    else if (prSum != sum)
                    {
                        areIdentical = false;
                        if (Math.Abs((int)(sum - prSum)) > maxDiff)
                        {
                            maxDiff = Math.Abs((int)(sum - prSum));

                        }
                    }
                    prSum = sum;
                }

            }
            if (areIdentical)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
