// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("введите координаты точки");
Console.Write("xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yb: ");
int yb = Convert.ToInt32(Console.ReadLine());

double line = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
Console.WriteLine($"Расстояние между точками = {line}.");