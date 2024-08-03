using System.Runtime.CompilerServices;

int n=int.Parse(Console.ReadLine());

int sumOfChars = 0;
for (int i = 0; i < n; i++)
{
    char symbol=char.Parse(Console.ReadLine());
    sumOfChars += symbol;
}
Console.WriteLine($"The sum equals: {sumOfChars}");