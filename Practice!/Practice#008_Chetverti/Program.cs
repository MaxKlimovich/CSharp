// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и 
// 2. выдаёт номер четверти плоскости, в которой находится эта
// точка.


Console.WriteLine("введите координаты точки");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else
// {
//     Console.WriteLine("Введены не корректные координаты");
// }

// Решаем с помощью метода

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return ("Первая четверть");
    if (xc < 0 && yc > 0) return ("Вторая четверть");
    if (xc < 0 && yc < 0) return ("Третья четверть");
    if (xc > 0 && yc < 0) return ("Четвертая четверть");
    return ("Введены не корректные координаты");
}

string result = Quarter(x, y);
Console.WriteLine(result);
