// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("введите координаты точки");
Console.Write("xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

// double line = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
double line = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2) );
Console.WriteLine($"Расстояние между точками = {line}.");