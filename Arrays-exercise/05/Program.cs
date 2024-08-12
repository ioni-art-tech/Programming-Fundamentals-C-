int[] arr = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


for (int i = 0; i < arr.Length; i++)
{
    bool isItTop = true;
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] <= arr[j])
        {
            isItTop = false;
            break;
        }
    }
    if (isItTop)
    {
        Console.Write(arr[i]+" ");
    }
}