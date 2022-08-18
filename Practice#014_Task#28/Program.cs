// Напишите программу, которая:
// 1. На вход принимает число N.
// 2. Выдает произведение чисел от 1 до N.

                                                    // В FOR

// Console.WriteLine("Введите число N");
// int number = Convert.ToInt32(Console.ReadLine());
// int perf = 1;

// for (int i = 1; i <= number; i++)
// {
//     perf *= i;
// }
// Console.WriteLine($"Произведение чисел от 1 до {number} = {perf}");


                                                // В Методе + FOR

// Console.WriteLine("Введите число N");
// int number = Convert.ToInt32(Console.ReadLine());

// int NumPerf(int num)
// {
//     int perf = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         perf *= i;
//     }
//     return perf;
// }
// int res = NumPerf(number);
// Console.WriteLine($"Произведение чисел от 1 до {number} = {res}");

                                                    // В Методе

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int NumPerf(int num)
{
    int perf = 1;
    int i = 1;
    while (i <= num)
    {
        
        perf *= i;
        i++;
    }
    return perf;
}
int res = NumPerf(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {res}");