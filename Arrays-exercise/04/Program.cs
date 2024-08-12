int[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int rotations=int.Parse(Console.ReadLine());

int timesToRotate=rotations%numbers.Length;
    for (int i = 1; i <= timesToRotate; i++)
    {
        int temp = numbers[0];

        for (int j = 1; j < numbers.Length; j++)
        {
            numbers[j - 1] = numbers[j];
        }
        numbers[numbers.Length - 1] = temp;

    }


Console.WriteLine(string.Join(" ", numbers));