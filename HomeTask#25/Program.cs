

// Напишите цикл который:
// 1. Принимает на вход 2 числа A и B.
// 2. Возводит число A в натуральную степень B.


Console.WriteLine("Напишите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B");
int B = Convert.ToInt32(Console.ReadLine());

int x = A;
int stepen = B;

Console.WriteLine("A * B = " + Math.Pow(x, stepen));
