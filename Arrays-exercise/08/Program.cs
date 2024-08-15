int[] arr = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();
int sum=int.Parse(Console.ReadLine());
int pairOne = 0;
int pairTwo = 0;

for (int i = 0; i < arr.Length; i++)
{
    
    for (int j = i+1; j < arr.Length; j++)
    {
       int  currSum = arr[i]+arr[j];
        if (currSum==sum)
        {
            Console.WriteLine($"{arr[i]} {arr[j]}");
        }
    }
}