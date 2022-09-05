

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Console.Write("Enter positive number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int SumPositiveNumb(int num)
// {
//     if (num / 10 <= 0) return sum += num % 10;
//     sum += SumPositiveNumb(num / 10);
//     return sum += num % 10;
// }



// int res = SumPositiveNumb(n);
// Console.Write(res);


Console.Write("Enter positive number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int SumPositiveNumb(int num)
{
    int sum = num % 10;

    if (num > 0) sum += SumPositiveNumb(num/10);
    return sum;
}
int res = SumPositiveNumb(n);
Console.Write(res);