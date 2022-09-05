

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n : ");
int n = Convert.ToInt32(Console.ReadLine());

void NatureNumber(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write($"{num2} ");
        return;
    }
    if (num2 > num1)
    {
        Console.Write($"{num2} ");
    }
    NatureNumber(num1, num2 - 1);
    Console.Write($"{num2} ");
}
void NatureNumber2(int number1, int number2)
{
    if (number2 == number1)
    {
        Console.Write($"{number1} ");
        return;
    }
    Console.Write($"{number1} ");
    NatureNumber(number2, number1 - 1);

}
if (m > n)
{
    NatureNumber2(m,n);
    // Console.WriteLine("Error");
}
else NatureNumber(m, n);