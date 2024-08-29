int[] arr = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
while (arr.Length>1)
{
    int[] copy = new int[arr.Length - 1];
    for (int i = 0; i < arr.Length-1; i++)
    {
        copy[i] = arr[i] + arr[i + 1];
    }
    arr = copy;
}

Console.WriteLine(string.Join(" ", arr));