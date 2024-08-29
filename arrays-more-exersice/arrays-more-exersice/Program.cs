int n = int.Parse(Console.ReadLine());
string[] names = new string[n];
for (int i = 0; i < n; i++)
{
    names[i] = Console.ReadLine();
}


int[] result= new int[n];
for (int i=0; i<n; i++)
{
    string curr=names[i];
    int sumVowels = 0;
    int sumConsonants = 0;
    int sumName = 0;
    for (int j = 0; j < curr.Length; j++)
    {
        char c = curr[j];
        bool isVowel = "aeiouAEIOU".Contains(c);
        //bool isConsonant= " BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".Contains(c);
        if (isVowel)
        {
            sumName += c * curr.Length;
        }
        else
        {
            sumName += c/curr.Length;
        }
    }
   
    result[i]=sumName;
}

Array.Sort(result);
for (int i = 0; i < n; i++)
{
    Console.WriteLine(result[i]);
}


