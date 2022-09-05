

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n : ");
int n = Convert.ToInt32(Console.ReadLine());

int MultiPly(int a, int b)
{
    int res = a;
    if (b == 0) return 1;
    else
    {
        res *= MultiPly(a, b - 1);
    }
    return res;
}

int res = MultiPly(m, n);
Console.WriteLine(res);