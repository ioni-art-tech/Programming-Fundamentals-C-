int numPeople = int.Parse(Console.ReadLine());
int pCapacity = int.Parse(Console.ReadLine());

int courses = (int)Math.Ceiling(numPeople / (double)pCapacity);
Console.WriteLine(courses);