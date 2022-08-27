

// Напишите цикл который:
// 1. Принимает на вход 2 числа A и B.
// 2. Возводит число A в натуральную степень B.

//С помощью метода

// Console.WriteLine("Напишите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Напишите число B");
// int B = Convert.ToInt32(Console.ReadLine());

// int x = A;
// int stepen = B;

// Console.WriteLine("Число {A} степени {B} => " + Math.Pow(x, stepen));

// С помощью метода


Console.WriteLine("Напишите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B");
int B = Convert.ToInt32(Console.ReadLine());


int n = A;
int n2 = B;
int pow = 1;

for (int i = 0; i < n2; i++)
{
    pow = (pow * n);
} 


Console.WriteLine($"Число {A} степени {B} => {pow} ({n}){n2} ");