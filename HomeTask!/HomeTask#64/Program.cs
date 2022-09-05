

// Задача 64 
// Задайте значение M и N. 
// Напишите программу, которая выведет все натуральне числа в промежутке от N до 1. 
// С помощью рекурсии.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NatureNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NatureNumber(num - 1);

}

int res = NatureNumber(number);
Console.WriteLine($"N = {number} -> {}")
;/A