Console.WriteLine("введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите b:");
int b = int.Parse(Console.ReadLine());
if (a>b)
{
Console.Write($"Max = a = {a}");
Console.Write($" Min = b = {b}");
}
else
if (b>a)
{
Console.Write($"Max = b = {b}");
Console.Write($" Min = a = {a}");
}
else

    Console.Write($"a = b= {a}");

