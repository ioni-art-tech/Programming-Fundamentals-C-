int n=int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    int currI = i;
    int sum = 0;
    bool isItSpecial = false;

    while (currI > 0)
    {
        int digit = currI % 10;
        currI /= 10;
        sum += digit;
    }
    if (sum==5 || sum==7 ||sum==11)
    {
        isItSpecial = true;int n=int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    int currI = i;
    int sum = 0;
    bool isItSpecial = false;

    while (currI > 0)
    {
        int digit = currI % 10;
        currI /= 10;
        sum += digit;
    }
    if (sum==5 || sum==7 ||sum==11)
    {
        isItSpecial = true;
    }
    Console.WriteLine($"{i} -> {isItSpecial}");
}

    }
    Console.WriteLine($"{i} -> {isItSpecial}");
}
