Console.Write("Введите значение 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение 2: ");
int b = int.Parse(Console.ReadLine()!);
if(a < b)
{
    Console.Write("min = ");
    Console.WriteLine(a);
    Console.Write("max = ");
    Console.Write(b);
}
else if(a > b)
{
    Console.Write("min = ");
    Console.WriteLine(b);
    Console.Write("max = ");
    Console.Write(a);
}
else if (a == b)
{
    Console.Write("error");   
}