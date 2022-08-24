

// Задача 42: 
// 1. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecimToBinary(int num)
{
    int result = 0;
    int factor = 1;

    while (num > 0)
    {
        result += num % 2*factor;
        num /= 2;
        factor *= 10;
    }
    return result;
}
int res = DecimToBinary(number);
Console.WriteLine($"{number} -> {res}");