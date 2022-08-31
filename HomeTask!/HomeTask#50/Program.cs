

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


void PrintElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
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



Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix = CreateMatrixRndInt(m, n, 0, 10);
PrintElem(OurMatrix);

Console.Write("Введите индекс столбца : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки : ");
int m1 = Convert.ToInt32(Console.ReadLine());
if (m1 >= 0 && m1 < OurMatrix.GetLength(0) && n1 >= 0 && n1 < OurMatrix.GetLength(1))
{
    Console.WriteLine($"Элемент массива ({n1}, {m1}) : {OurMatrix[m1, n1]}");
}
else { Console.WriteLine($"Элемент массива ({n1}, {m1}) в заданном массиве отсутствует."); }



