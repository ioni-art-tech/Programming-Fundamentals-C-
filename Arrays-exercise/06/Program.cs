int[] arr = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();


bool isEqual = false;
for (int i = 0; i < arr.Length; i++)
{
    int sumLeft = 0;
    int sumRight = 0;
    for (int j = i+1; j < arr.Length; j++)
    {
        sumRight += arr[j];
    }

    for (int k = 0; k < i; k++)
    {
        sumLeft += arr[k];
    }

    if (sumLeft==sumRight)
    {
        isEqual = true;
        Console.WriteLine(i);
    }
}
if (isEqual==false)
{
    Console.WriteLine("no");
}