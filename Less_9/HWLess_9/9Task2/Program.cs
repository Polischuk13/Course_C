//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.

int Power(int A, int B)
{
    if(B==A) return A;
    return B + Power(A, B - 1);
}


int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Power(A,B));