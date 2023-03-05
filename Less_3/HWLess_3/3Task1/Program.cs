Console.WriteLine("Введите пятизначное число ");
void Palindrom (string numbers)
{
        
    if(string.IsNullOrEmpty(numbers))
        {
        Console.WriteLine("Ввод не должен быть пустым ");
        Palindrom(Console.ReadLine()); 
        return;
        }
    if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
        {
        Console.WriteLine("Да");
        }
    else Console.WriteLine("Нет");
} 
Palindrom(Console.ReadLine());