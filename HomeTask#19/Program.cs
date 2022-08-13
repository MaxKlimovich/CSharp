// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 → нет
// 23432 → да
// 12821 → да

// Если ((число / 10000) == (число % 10) && (число / 1000) == (число % 100)), то это полиндром.
// Иначе, нет.

Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());



if ((num / 10000) == (num % 10) && (num / 1000) == (num % 100))
    Console.WriteLine($"{num} -> да");
else
    Console.WriteLine($"{num} -> нет");

Console.ReadLine();

// int Pol(int num)
// {
//     if ((num / 10000) == (num % 10) && (num / 1000) == (num % 100))
//     Console.WriteLine($"{num} -> да");
// else
//     Console.WriteLine($"{num} -> нет");
// }

// int pol = Pol(num); 
// string result = pol ($"{num > 99999 || num < 9999}") ? pol.ToString() : "не является корректным числом";
// Console.WriteLine($" {num} => ");