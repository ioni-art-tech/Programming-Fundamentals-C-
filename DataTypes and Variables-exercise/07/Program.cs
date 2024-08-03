int n=int.Parse(Console.ReadLine());

int waterInTank = 0;
for (int i = 0; i < n; i++)
{
    int currLitres = int.Parse(Console.ReadLine());
    waterInTank += currLitres;
    if (waterInTank>255)
    {
        Console.WriteLine("Insufficient capacity!");
        waterInTank -= currLitres;
    }
}
Console.WriteLine(waterInTank);