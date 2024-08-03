int n = int.Parse(Console.ReadLine());

int sum=0;
while (n>0)
{
    int digit=n%10;
    n /= 10;
    sum += digit;
}

Console.WriteLine(sum);