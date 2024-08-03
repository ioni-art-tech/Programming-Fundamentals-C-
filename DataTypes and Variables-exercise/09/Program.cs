int startingYield = int.Parse(Console.ReadLine());

int daysOperated = 0;
long extractedSpice = 0;
while (startingYield >= 100)
{
    extractedSpice += startingYield - 26;
    startingYield -= 10;
    daysOperated++;
}
if (extractedSpice>=26)
{
    extractedSpice -= 26;
}


Console.WriteLine(daysOperated);
Console.WriteLine(extractedSpice);