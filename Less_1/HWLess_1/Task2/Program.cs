Console.Write("Введите значение 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение 3: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(max < b)
{
    max = b;
}
if(max < c)
{
    max = c;
}
Console.Write(max);