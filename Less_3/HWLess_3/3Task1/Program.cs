void Palindrom (string numbers)
{
    if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
Palindrom(Console.ReadLine());