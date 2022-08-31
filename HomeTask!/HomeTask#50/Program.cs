

// Задача 50.
// 1. Напишите программу которая на вход принимает позиции элемента2 в двумерном массиве
// 2. Возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 6 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 → такого числа в массиве



int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}

void PrintElem(int[,] array)
{

    for (int i = 1; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 1; j < array.GetLength(1); j++)
        {

            if (j < array.GetLength(0)) Console.Write($"{array[i, j],4}");
            else Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

bool ExistElem(int[,] array, int a1, int b1)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    return a1 > row || b1 > col;
}



Console.WriteLine("Введите координаты строк a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты столбиков b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] twoDArray = CreateMatrixRndInt(5, 5, 10, 99);
PrintElem(twoDArray);
Console.WriteLine();
bool res = ExistElem(twoDArray, a, b);
Console.WriteLine(twoDArray[a, b]);


if (a >= 0 && b < twoDArray.GetLength(0) && b >= 0 && a < twoDArray.GetLength(1))
{
    Console.WriteLine($"Элемент массива ({a}, {b}) : {twoDArray[a, b]}");
}
else { Console.WriteLine($"Элемент массива ({a}, {b}) в заданном массиве отсутствует."); }



