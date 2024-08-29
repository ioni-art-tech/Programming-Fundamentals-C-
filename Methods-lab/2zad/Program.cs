using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);

        }
        
        static void PrintGrade(double grade)
        {
            if (grade>=2 && grade<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade <= 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 4 && grade <= 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 5 && grade <= 5.50)
            {
                Console.WriteLine("Very Good");
            }
            else if(grade==6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
