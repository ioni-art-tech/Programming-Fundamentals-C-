int[] arr = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int maxSequence = 0;
int maxNumber = 0;

for (int i = 0; i < arr.Length; i++)
{
    int currCount = 0;
    for (int j = i; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            currCount++;
        }
        else
        {
            break;
        }
    }
    if (currCount>maxSequence)
    {
        maxSequence = currCount;
        maxNumber = arr[i];
    }
}

for (int k = 0; k < maxSequence; k++)
{
    Console.Write(maxNumber + " ");
}