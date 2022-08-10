// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно



// Демонстрация без метода!

// Console.WriteLine("введите первое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int sqrt = number1 % number2;

// if (sqrt == 0)
// {
//     Console.WriteLine("кратно");
// } 
// else 
// {
//     Console.WriteLine($"не кратно, остаток {sqrt} ");
// }

// Демонстрация с методом

Console.WriteLine("введите первое число ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

void CheckNum (int number1, int number2)
{
    if (number1 % number2 == 0)
    {
        Console.WriteLine($"Номер {number1} кратен  {number2}.");
    }
    else 
    {
        Console.WriteLine("показываем остаток" + number1 % number2);
    }
}

CheckNum(firstNum, secondNum);