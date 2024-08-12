using System;

int[] arr1 =Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] arr2 =Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int sum = 0;

bool isItIdentical = true;
for (int i = 0; i < arr1.Length; i++)
{
	if (arr1[i] != arr2[i])
	{
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        isItIdentical = false;
        break;
	}
    else
    {
        sum += arr1[i ]+ arr2[i];
    }
}
if (isItIdentical)
{
    Console.WriteLine($"Arrays are identical.Sum: {sum}");
}
