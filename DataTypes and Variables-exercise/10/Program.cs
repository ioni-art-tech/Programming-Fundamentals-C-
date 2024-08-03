int n=int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int originalN = n;
int pokedTargets = 0;
while (n>=m)
{
    n -= m;
    pokedTargets++;

    if (n==0.5m*originalN && y!=0)
    {
        n /= y;
    }

}

Console.WriteLine(n + "\n" + pokedTargets);