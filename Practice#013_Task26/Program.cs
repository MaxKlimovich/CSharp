// Задача 26: 
// Напишите программу, которая:
// 1. Принимает на вход число.
// 2. Выдает количество цифр в числе.

// Выполняется с помощью While

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (number >= 10)
// {
//     number = number / 10;
//     count ++;
// }

// Console.WriteLine($"Количество цифр в = {count}");


// Выполнять с помощью FOR

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// for (; number >= 10; number = number / 10)
// {
//     count++;
// }
// Console.WriteLine($"Имеет количество цифр = {count}");

//Выполняется с помощью метода

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int CountNumbers(int num)
{
    int counter = 1;
    while (num >= 10)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}
int res = CountNumbers(number);
Console.WriteLine($"Получим количество цифр из {number} = {res}");




