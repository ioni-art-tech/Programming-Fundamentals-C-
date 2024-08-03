int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());

long firstResult = (long)n1 + n2;
long secondResult = firstResult / n3 ;
long finalResult = secondResult * n4 ;

Console.WriteLine(finalResult);
