// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("введите первое число ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool CheckNum (int number1, int number2)
{
    return  number1 * number1 == number2 || number2 % number2 == number1;
}

bool result = CheckNum(firstNum, secondNum);

Console.WriteLine(result ? "yes" : "no");