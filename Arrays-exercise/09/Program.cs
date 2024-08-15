int n = int.Parse(Console.ReadLine());
string input;

int br = 0;
int leftMostIndex = int.MaxValue;
int leftMostArr = 0;
int bestCountOf1 = -1;
int superBr = 0;
int sum = int.MinValue;
int[] result = new int[n];
while ((input = Console.ReadLine()) != "Clone them!")
{

    int[] arr = input
       .Split('!', StringSplitOptions.RemoveEmptyEntries)
       .Select(int.Parse)
       .ToArray();
    br++;
    int currSum = 0;
    int maxCountOf1 = 0;
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int currCount = 0;
        if (arr[i] == 1)
        {
            for (int j = i + 1; j < arr.Length; j++)
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
        }
        currSum += arr[i];

        if (currCount > maxCountOf1)
        {
            maxCountOf1 = currCount;
            index = i;
        }

    }
    if (maxCountOf1 > bestCountOf1)
    {
        bestCountOf1 = maxCountOf1;
        superBr = br;
        result = arr;
        sum = currSum;
    }

    int previousIndex = leftMostIndex;
    if (maxCountOf1 == bestCountOf1)
    {
        if (index < leftMostIndex)
        {
            leftMostIndex = index;
            superBr = br;
            result = arr;
            sum = currSum;
        }

    }
    //leftMostIndex = temp;
    if (maxCountOf1 == bestCountOf1 && index == previousIndex)
    {
        if (sum <= currSum)
        {
            sum = currSum;
            superBr = br;
            result = arr;
        }

    }


}

Console.WriteLine($"Best DNA sample {superBr} with sum: {sum}.");
Console.WriteLine(string.Join(" ", result));





