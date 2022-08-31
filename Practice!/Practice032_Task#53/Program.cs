

// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (j < array.GetLength(0) - 1) Console.Write($"{array[i, j],4}");
            else Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void SwapArray(int[,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0) -1;
    int col = matrix.GetLength(1);
    for (int i = 0; i < col; i++)
    {
        int elem = matrix[lastRow, i];
        matrix[lastRow, i] = matrix[firstRow, i];
        matrix[firstRow, i] = elem;
    }
}

int[,] matr = CreateMatrixRndInt(4, 4, 10, 99);
PrintElem(matr);
Console.WriteLine();
SwapArray(matr);
PrintElem(matr);

