// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string QuarterNum(int numX)
{
    if (numX == 1) return "Диапазон : x > 0 и y > 0";
    if (numX == 2) return "Диапазон : x < 0 и y > 0";
    if (numX == 3) return "Диапазон : x < 0 и y < 0";
    if (numX == 4) return "Диапазон : x > 0 и y < 0";
    return "Введены не корректные координаты";
}

string result = QuarterNum(number);
Console.WriteLine(result);