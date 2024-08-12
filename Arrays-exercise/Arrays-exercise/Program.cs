int n=int.Parse(Console.ReadLine());
int[] wagons = new int[n];

int sumOfPassengers = 0;
for (int i = 0; i < wagons.Length; i++)
{
    wagons[i] = int.Parse(Console.ReadLine());
    sumOfPassengers += wagons[i];
}

Console.WriteLine(string.Join(" ", wagons) );
Console.WriteLine(sumOfPassengers);