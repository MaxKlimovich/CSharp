

// Задача 24: Напишите программу.
// 1. Принимает на вход число (А).
// 2. Выдаёт сумму чисел от 1 до А.
//
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());


int sum = 0;

for (int i = 1; i <= num ; i++)
{
    sum = i + sum;
}

Console.WriteLine(sum);