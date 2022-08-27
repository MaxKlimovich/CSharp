

// Задача 40: 
// 1. Напишите программу, которая принимает на вход три числа
// 2. Проверяет, может ли существовать треугольник с сторонами такой длины.
// "Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон"

Console.Write("Введите число #1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #3: ");
int c = Convert.ToInt32(Console.ReadLine());

// bool CheckTriangle(int a1, int b1, int c1)
// {
//     if (a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1 )
//     {
//         return true;
//     }
//     return false;
// }

// bool result = CheckTriangle(a,b,c);
// if (result) Console.Write("Является треугольниками");

// else Console.Write("Не являются треугольниками");


//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Натернарный оператор


bool CheckTriangle(int a1, int b1, int c1)
{
    return a1 + b1 > c1 && b1 + c1 > a1 && c1 + a1 > b1; 
}

bool result = CheckTriangle(a,b,c);
Console.Write(result ? "Являются треугольниками" : "Не является треугольниками");
