﻿

// Задача 46
// Задайте двумерный массив.
// Необходимо вывести в консоль результат.

int[,] CreateMatrixRnxInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)   // matrix.GetLength(0)
    {
        for (int j = 0; j < col; j++)  // matrix.GetLength(1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            if (j < matrix.GetLength(0) -1) Console.Write($"{matrix[i,j], 4}");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrixRnxInt(3,4,-99,99);
PrintMatrix(matrix);